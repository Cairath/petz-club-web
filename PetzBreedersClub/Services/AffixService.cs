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
	Task<IResult> GetOwnedPendingAffixes();
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

		var affixes = 
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

		return Results.Ok(affixes);
	}

	public async Task<IResult> GetOwnedPendingAffixes()
	{
		var userId = int.Parse(_userService.GetUserId()!);

		var affixes =
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

		return Results.Ok(affixes);
	}
}