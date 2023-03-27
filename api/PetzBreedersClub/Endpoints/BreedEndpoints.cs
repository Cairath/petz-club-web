using Microsoft.AspNetCore.Mvc;
using PetzBreedersClub.Database.Models.Enums;
using PetzBreedersClub.DTOs.Breeds;
using PetzBreedersClub.Services;

namespace PetzBreedersClub.Endpoints;

public static class BreedEndpoints
{
	public static void MapBreedEndpoints(this IEndpointRouteBuilder routes)
	{
		var group = routes.MapGroup("/api/breeds").WithTags("Breeds");

		group.MapGet("/names", async ([FromQuery]Species? species, IBreedService breedsService) =>
			{
				return await breedsService.GetBreedNamesList(species);
			})
			.WithName("GetBreedNamesList")
			.Produces<List<BreedNameListItem>>()
			.WithOpenApi();

		group.MapGet("/varieties", async ([FromQuery] int breedId, IBreedService breedsService) =>
			{
				return await breedsService.GetBreedVarietiesList(breedId);
			})
			.WithName("GetBreedVarieties")
			.Produces<List<BreedVarietyListItem>>()
			.WithOpenApi();
	}
}