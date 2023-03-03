using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database;
using PetzBreedersClub.DTOs.Affixes;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Services;

public interface IAffixService
{
	Task<IResult> RegisterAffix(AffixRegistrationForm affixRegistrationForm);
	Task<IResult> GetOwnedAffixes();
	Task<IResult> CancelPendingAffixRegistration(int pendingAffixId);
	Task<IResult> GetAffixProfile(int affixId);
}

public class AffixService : IAffixService
{
	private readonly Context _context;
	private readonly IUserService _userService;

	public AffixService(Context context, IUserService userService)
	{
		_context = context;
		_userService = userService;
	}

	public async Task<IResult> RegisterAffix(AffixRegistrationForm affixRegistrationForm)
	{
		var userId = int.Parse(_userService.GetUserId()!);
		var user = _context.Users.Include(u => u.Member).FirstOrDefault( u => u.Id == userId);

		if (user == null)
		{
			return Results.Unauthorized();
		}

		//todo validate

		_context.Add(new AffixEntity
		{
			Name = affixRegistrationForm.Name, Syntax = affixRegistrationForm.Syntax, OwnerId = user.Member.Id, Status = AffixStatus.Active
		});

		await _context.SaveChangesAsync();

		return Results.Ok();
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
}