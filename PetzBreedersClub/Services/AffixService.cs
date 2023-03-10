using Fastenshtein;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database;
using PetzBreedersClub.DTOs.Affixes;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PetzBreedersClub.Services.Notifications;
using AffixStatus = PetzBreedersClub.Database.Models.Enums.AffixStatus;
using FluentValidation;

namespace PetzBreedersClub.Services;

public interface IAffixService
{
	Task<IResult> RegisterAffix(AffixRegistrationForm affixRegistrationForm);
	Task<IResult> GetOwnedAffixes();
	Task<IResult> CancelPendingAffixRegistration(int pendingAffixId);
	Task<IResult> GetAffixProfile(int affixId);
	Task<IResult> GetPendingAffixRegistrations();
	Task<IResult> ApproveAffix(int pendingAffixId);
	Task<IResult> RejectAffix(AffixRejection affixRejection);
	Task<IResult> DeleteAffix(int affixId);
	Task<IResult> SetActive(int affixId, bool active);
	Task<IResult> GetSimilarNames(string affixName);
}

public class AffixService : IAffixService
{
	private readonly Context _context;
	private readonly IUserService _userService;
	private readonly IMemoryCache _cache;
	private readonly AffixRegistrationFormValidator _affixRegistrationFormValidator;

	public AffixService(Context context, IUserService userService, IMemoryCache cache, AffixRegistrationFormValidator affixRegistrationFormValidator)
	{
		_context = context;
		_userService = userService;
		_cache = cache;
		_affixRegistrationFormValidator = affixRegistrationFormValidator;
	}

	public async Task<IResult> GetOwnedAffixes()
	{
		var userId = int.Parse(_userService.GetUserId()!);
	
		var registeredAffixes =
			await _context.Affixes
			.Where(a => a.Owner.UserId == userId && a.Status != AffixStatus.PendingRegistration)
			.Select(a => new RegisteredAffixListItem
			{
				Id = a.Id,
				Name = a.Name,
				PetsCount = a.Pets.Count,
				Syntax = a.Syntax,
				RegistrationDate = a.RegistrationDate,
				Status = a.Status
			}).ToListAsync();

		var pendingAffixes =
			await _context.Affixes
				.Where(a => a.Owner.UserId == userId && a.Status == AffixStatus.PendingRegistration)
				.Select(a => new RegisteredAffixListItem
				{
					Id = a.Id,
					Name = a.Name,
					PetsCount = 0,
					Syntax = a.Syntax,
					RegistrationDate = a.CreatedDate,
					Status = a.Status
				}).ToListAsync();

		var affixInfo = new OwnedAffixes
		{
			Allowed = 50,
			Owned = registeredAffixes.Count + pendingAffixes.Count,
			Registered = registeredAffixes,
			Pending = pendingAffixes
		};

		return Results.Ok(affixInfo);
	}

	public async Task<IResult> CancelPendingAffixRegistration(int pendingAffixId)
	{
		var userId = int.Parse(_userService.GetUserId()!);

		var pendingAffix =
			await _context.Affixes
				.Where(a => a.Owner.UserId == userId && a.Id == pendingAffixId && a.Status == AffixStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		//todo validation
		if (pendingAffix == null)
		{
			return Results.Unauthorized();
		}

		_context.Remove(pendingAffix);
		await _context.SaveChangesAsync();

		_cache.Remove(CacheKeys.GetPendingAffixRegistrationsRegisteredAffixes);

		return Results.Ok();
	}

	public async Task<IResult> GetAffixProfile(int affixId)
	{
		var affixProfile =
			await _context.Affixes
				.Where(a => a.Id == affixId && a.Status != AffixStatus.PendingRegistration)
				.Select(a => new AffixProfileData
				{
					Id = a.Id,
					Name = a.Name,
					OwnerId = a.OwnerId,
					OwnerName = a.Owner.Name
				}).FirstOrDefaultAsync();

		return Results.Ok(affixProfile);
	}

	public async Task<IResult> GetPendingAffixRegistrations()
	{
		var registeredAffixes = await _cache.GetOrCreateAsync(CacheKeys.GetPendingAffixRegistrationsRegisteredAffixes,
			 entry =>
			{
				entry.SetSlidingExpiration(TimeSpan.FromSeconds(15));

				return _context.Affixes
					.Where(a => a.Status != AffixStatus.PendingRegistration)
					.Select(a => new { a.Id, a.Name, a.Syntax })
					.ToListAsync();
			});

		var pendingAffixes =
			await _context.Affixes
				.Where(a => a.Status == AffixStatus.PendingRegistration)
				.Select(a => new PendingAffixRegistration
				{
					Id = a.Id,
					Name = a.Name,
					Syntax = a.Syntax,
					OwnerId = a.OwnerId,
					OwnerName = a.Owner.Name,
					SubmissionDate = a.CreatedDate,
					SimilarNames = new List<SimilarName>()
				}).ToListAsync();

		if (registeredAffixes == null) { return Results.Ok(pendingAffixes); }
		{
			foreach (var pendingAffix in pendingAffixes)
			{
				foreach (var registeredAffix in registeredAffixes)
				{
					var distance = _cache.GetOrCreate($"{pendingAffix.Name}{registeredAffix.Name}",
						entry =>
						{
							entry.SetSlidingExpiration(TimeSpan.FromMinutes(5));
							return new Levenshtein(pendingAffix.Name).DistanceFrom(registeredAffix.Name);
						});

					var longerLength = Math.Max(pendingAffix.Name.Length, registeredAffix.Name.Length);
					var similarity = (longerLength - distance) / (float)longerLength * 100;

					if (similarity > 60)
					{
						pendingAffix.SimilarNames.Add(new SimilarName
						{
							Id = registeredAffix.Id,
							Name = registeredAffix.Name,
							SimilarityPercentage = (int)similarity,
							Syntax = registeredAffix.Syntax
						});
					}
				}
			}
		}

		return Results.Ok(pendingAffixes);
	}

	public async Task<IResult> RegisterAffix(AffixRegistrationForm affixRegistrationForm)
	{
		affixRegistrationForm.Name = affixRegistrationForm.Name.Trim();

		var context = new ValidationContext<AffixRegistrationForm>(affixRegistrationForm)
		{
			RootContextData =
			{
				["UserId"] = _userService.GetUserId()
			}
		};

		var validationResult = await _affixRegistrationFormValidator.ValidateAsync(context);

		if (!validationResult.IsValid)
		{
			return Results.ValidationProblem(validationResult.ToDictionary());
		}

		var userId = int.Parse(_userService.GetUserId()!);
		var user = _context.Users.Include(u => u.Member).FirstOrDefault(u => u.Id == userId);

		_context.Add(new AffixEntity
		{
			Name = affixRegistrationForm.Name,
			Syntax = affixRegistrationForm.Syntax,
			OwnerId = user!.Member.Id,
			Status = AffixStatus.PendingRegistration
		});

		await _context.SaveChangesAsync();

		_cache.Remove(CacheKeys.GetPendingAffixRegistrationsRegisteredAffixes);

		return Results.Ok();
	}

	public async Task<IResult> ApproveAffix(int pendingAffixId)
	{
		//todo validate
		var affix = _context.Affixes
			.Include(u => u.Owner)
			.FirstOrDefault(a => a.Id == pendingAffixId && a.Status == AffixStatus.PendingRegistration);

		if (affix == null)
		{
			return Results.BadRequest("Test Message");
		}

		affix.Status = AffixStatus.Active;
		affix.RegistrationDate = DateTime.UtcNow;
		affix.RegistrarId = await _userService.GetMemberId();

		_context.Add(NotificationGenerator.AffixRegistrationApproved(affix.Id, affix.Name, affix.OwnerId));
		await _context.SaveChangesAsync();
		
		_cache.Remove(CacheKeys.GetPendingAffixRegistrationsRegisteredAffixes);

		return Results.Ok();
	}

	public async Task<IResult> RejectAffix(AffixRejection affixRejection)
	{
		//todo validate
		var affix = _context.Affixes
			.Include(u => u.Owner )
			.FirstOrDefault(a => a.Id == affixRejection.Id&& a.Status == AffixStatus.PendingRegistration);

		if (affix == null)
		{
			return Results.BadRequest("Test Message");
		}

		_context.Remove(affix);
		_context.Add(NotificationGenerator.AffixRegistratonRejected(affix.Name, affixRejection.Reason, affix.OwnerId));

		await _context.SaveChangesAsync();

		_cache.Remove(CacheKeys.GetPendingAffixRegistrationsRegisteredAffixes);

		return Results.Ok();
	}

	public async Task<IResult> DeleteAffix(int affixId)
	{
		//todo validate - pets count 0
		var affix = _context.Affixes
			.Include(a => a.Pets)
			.FirstOrDefault(a => a.Id == affixId && a.Status != AffixStatus.PendingRegistration);

		if (affix == null || affix.Pets.Count != 0)
		{
			return Results.BadRequest();
		}

		_context.Remove(affix);

		await _context.SaveChangesAsync();

		return Results.Ok();
	}
	public async Task<IResult> SetActive(int affixId, bool active)
	{
		//todo validate
		var affix = _context.Affixes
			.FirstOrDefault(a => a.Id == affixId && a.Status != AffixStatus.PendingRegistration);

		if (affix == null)
		{
			return Results.BadRequest();
		}

		affix.Status = active ? AffixStatus.Active : AffixStatus.Inactive;

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> GetSimilarNames(string affixName)
	{
		var registeredAffixes = await _cache.GetOrCreateAsync(CacheKeys.GetSimilarAffixesRegisteredAffixes,
			cacheEntry =>
			{
				cacheEntry.SlidingExpiration = TimeSpan.FromSeconds(10);
				return _context.Affixes
					.Where(a=>a.Status != AffixStatus.PendingRegistration)
					.Select(a => new { a.Id, a.Name, a.Syntax })
					.ToListAsync();
			});

		var similarNames = new List<SimilarName>();

		if (registeredAffixes == null)
		{
			return Results.Ok(similarNames);
		}

		foreach (var registeredAffix in registeredAffixes)
		{
			var distance = _cache.GetOrCreate($"{affixName}{registeredAffix.Name}",
				entry =>
				{
					entry.SetSlidingExpiration(TimeSpan.FromMinutes(5));
					return new Levenshtein(affixName).DistanceFrom(registeredAffix.Name);
				});

			var longerLength = Math.Max(affixName.Length, registeredAffix.Name.Length);
			var similarity = (longerLength - distance) / (float)longerLength * 100;

			if (similarity > 60)
			{
				similarNames.Add(new SimilarName
				{
					Id = registeredAffix.Id,
					Name = registeredAffix.Name,
					SimilarityPercentage = (int)similarity,
					Syntax = registeredAffix.Syntax
				});
			}
		}

		return Results.Ok(similarNames);
	}
}