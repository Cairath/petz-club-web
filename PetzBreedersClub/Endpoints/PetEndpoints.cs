using Microsoft.AspNetCore.Mvc;
using PetzBreedersClub.DTOs.Pets;
using PetzBreedersClub.Services;

namespace PetzBreedersClub.Endpoints;

public static class PetEndpoints
{
	public static void MapPetEndpoints(this IEndpointRouteBuilder routes)
	{
		var group = routes.MapGroup("/api/pets").WithTags("Pets");

		group.MapGet("/profile/{id}", async (int id, IPetService petService) =>
			{
				return await petService.GetPetProfile(id);
			})
			.WithName("GetPetProfile")
			.Produces<PetProfileData>()
			.WithOpenApi();

		group.MapGet("/pedigree/{id}/{generations}", async (int id, int generations, IPetService petService) =>
			{
				return await petService.GetPedigree(id, generations);
			})
			.WithName("GetPedigree")
			.Produces<Pedigree>()
			.WithOpenApi();

		group.MapGet("/list", async ([AsParameters]PetListRequest request, IPetService petService) =>
			{
				return await petService.GetPets(request);
			})
			.WithName("GetPets")
			.Produces<Paged<PetListItem>>()
			.WithOpenApi();
	}
}