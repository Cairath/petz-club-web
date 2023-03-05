using Fastenshtein;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database;
using PetzBreedersClub.DTOs.Affixes;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PetzBreedersClub.Database.Models.Enums;

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
}

public class AffixService : IAffixService
{
	private readonly Context _context;
	private readonly IUserService _userService;
	private readonly IMemoryCache _cache;

	public AffixService(Context context, IUserService userService, IMemoryCache cache)
	{
		_context = context;
		_userService = userService;
		_cache = cache;
	}

	public async Task<IResult> GetOwnedAffixes()
	{
		var userId = int.Parse(_userService.GetUserId()!);

		var registeredAffixes =
			await _context.Affixes

			.Where(a => a.Owner.UserId == userId)
			.Select(a => new RegisteredAffixListItem
			{
				Id = a.Id,
				Name = a.Name,
				PetsCount = a.Pets.Count,
				Syntax = a.Syntax,
				RegistrationDate = a.CreatedDate,
				Status = a.Status
			}).ToListAsync();

		var pendingAffixes =
			await _context.AffixesPendingRegistration
				.Where(a => a.Owner.UserId == userId)
				.Select(a => new RegisteredAffixListItem
				{
					Id = a.Id,
					Name = a.Name,
					PetsCount = 0,
					Syntax = a.Syntax,
					RegistrationDate = a.CreatedDate,
					Status = AffixStatus.PendingRegistration
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
			await _context.AffixesPendingRegistration
				.Where(a => a.Owner.UserId == userId && a.Id == pendingAffixId)
				.FirstOrDefaultAsync();

		if (pendingAffix == null)
		{
			return Results.Unauthorized();
		}

		_context.AffixesPendingRegistration.Remove(pendingAffix);
		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> GetAffixProfile(int affixId)
	{
		var affixProfile =
			await _context.Affixes

				.Where(a => a.Id == affixId)
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
		//todo: cache this!
		var registeredAffixes =
			await _context.Affixes
				.Select(a => new { a.Id, a.Name, a.Syntax })
				.ToListAsync();

		var pendingAffixes =
			await _context.AffixesPendingRegistration
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

		return Results.Ok(pendingAffixes);
	}

	public async Task<IResult> RegisterAffix(AffixRegistrationForm affixRegistrationForm)
	{
		var userId = int.Parse(_userService.GetUserId()!);
		var user = _context.Users.Include(u => u.Member).FirstOrDefault(u => u.Id == userId);

		if (user == null)
		{
			return Results.Unauthorized();
		}

		//todo validate

		_context.Add(new AffixPendingRegistrationEntity
		{
			Name = affixRegistrationForm.Name,
			Syntax = affixRegistrationForm.Syntax,
			OwnerId = user.Member.Id,
			RegistrationStatus = RegistrationStatus.Pending
		});

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> ApproveAffix(int pendingAffixId)
	{
		//todo validate
		var pendingAffix = _context.AffixesPendingRegistration
			.Include(u => u.Owner)
			.FirstOrDefault(pa => pa.Id == pendingAffixId);

		if (pendingAffix == null)
		{
			return Results.BadRequest("Test Message");
		}
		

		_context.Add(new AffixEntity
		{
			Name = pendingAffix.Name,
			Syntax = pendingAffix.Syntax,
			OwnerId = pendingAffix.OwnerId,
			Status = AffixStatus.Active,
		});

		_context.Remove(pendingAffix);

		//todo: notification

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> RejectAffix(AffixRejection affixRejection)
	{
		//todo validate
		var pendingAffix = _context.AffixesPendingRegistration
			.Include(u => u.Owner)
			.FirstOrDefault(pa => pa.Id == affixRejection.Id);

		if (pendingAffix == null)
		{
			return Results.BadRequest("Test Message");
		}

		_context.Remove(pendingAffix);

		//todo: notification

		await _context.SaveChangesAsync();

		return Results.Ok();
	}


}