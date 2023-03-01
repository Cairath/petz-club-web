using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database;
using PetzBreedersClub.DTOs.Affixes;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PetzBreedersClub.Services;

public interface IAffixService
{
	Task<IResult> RegisterAffix(AffixRegistrationForm affixRegistrationForm);
	Task<IResult> GetOwnedAffixes();
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
			Name = affixRegistrationForm.Name, AffixSyntax = affixRegistrationForm.AffixSyntax, OwnerId = user.Member.Id
		});

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> GetOwnedAffixes()
	{
		var userId = int.Parse(_userService.GetUserId()!);

		var affixes = await _context.Affixes.Where(a => a.Owner.UserId == userId).Select(a => new RegisteredAffixListItem
		{
			Name = a.Name,
			Syntax = a.AffixSyntax,
			RegistrationDate = a.CreatedDate
		}).ToListAsync();

		return Results.Ok(affixes);
	}
}