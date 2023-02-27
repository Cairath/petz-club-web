using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.DTOs.Breeds;

namespace PetzBreedersClub.Services;

public interface IBreedService
{
	Task<IResult> GetBreedNamesList(Species? species);
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
			Species = b.Species
		}).ToListAsync();

		return Results.Ok(breeds);
	}
}