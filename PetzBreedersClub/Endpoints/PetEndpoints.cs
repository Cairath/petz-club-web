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

		group.MapGet("/list", async ([AsParameters] PetListRequest request, IPetService petService) =>
			{
				return await petService.GetPets(request);
			})
			.WithName("GetPets")
			.Produces<Paged<PetListItem>>()
			.WithOpenApi();

		group.MapPost("/set-breeding-availability", async ([FromBody] BreedingAvailability breedingAvailability, IPetService petService) =>
			{
				return await petService.SetBreedingAvailability(breedingAvailability);
			})
			.WithName("SetBreedingAvailability")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/set-status", async ([FromBody] SetPetActiveStatus petActiveStatus, IPetService petService) =>
			{
				return await petService.SetStatus(petActiveStatus);
			})
			.WithName("SetPetActiveStatus")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/set-adult", async ([FromBody] int petId, IPetService petService) =>
			{
				return await petService.SetAdult(petId);
			})
			.WithName("SetAdult")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/set-bio", async ([FromBody] SetBioForm setBioForm, IPetService petService) =>
			{
				return await petService.SetBio(setBioForm);
			})
			.WithName("SetBio")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/upload-profile-pic/{petId}", async (int petId, [FromForm] IFormFile file, IPetService petService) =>
			{
				return await petService.UploadProfilePic(petId, file);
			})
			.WithName("UploadProfilePic")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/delete-profile-pic/{petId}", async (int petId, IPetService petService) =>
			{
				return await petService.DeleteProfilePic(petId);
			})
			.WithName("DeleteProfilePic")
			.RequireAuthorization()
			.WithOpenApi();
	}
}