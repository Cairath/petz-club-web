using Microsoft.AspNetCore.Mvc;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.DTOs.Auth;
using PetzBreedersClub.DTOs.Breeds;
using PetzBreedersClub.Services;
using PetzBreedersClub.Services.Auth;

namespace PetzBreedersClub.Endpoints;

public static class BreedEndpoints
{
	public static void MapBreedsEndpoints(this IEndpointRouteBuilder routes)
	{
		var group = routes.MapGroup("/api/breeds").WithTags("Breeds");

		group.MapGet("/names", async ([FromQuery]Species? species, IBreedService breedsService) =>
			{
				return await breedsService.GetBreedNamesList(species);
			})
			.WithName("GetBreedNamesList")
			.Produces<List<BreedNameListItem>>()
			.WithOpenApi();
	}
}