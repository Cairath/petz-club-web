using PetzBreedersClub.Database;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.DTOs.Breeds;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Services;

public interface IBreedService
{
	Task<IResult> GetBreedNamesList(Species? species);
	Task<IResult> GetBreedVarietiesList(int breedId);
}

public class BreedService : IBreedService
{
	private readonly Context _context;

	public BreedService(Context context)
	{
		_context = context;
	}

	public async Task<IResult> GetBreedNamesList(Species? species)
	{
		var query = _context.Breeds.AsQueryable();

		if (species != null)
		{
			query = query.Where(b => b.Species == species);
		}

		var breeds = await query.Select(b => new BreedNameListItem
		{
			Id = b.Id,
			Name = b.Name,
			Group = b.Group,
			Section = b.Section
		}).ToListAsync();

		return Results.Ok(breeds);
	}

	public async Task<IResult> GetBreedVarietiesList(int breedId)
	{
		var varieties = await _context.BreedVarieties
			.Where(bv => bv.BreedId == breedId)
			.Select(b => new BreedVarietyListItem()
			{
				Id = b.Id,
				Name = b.Name,
			}).ToListAsync();

		return Results.Ok(varieties);
	}
}