namespace PetzBreedersClub.Endpoints;

public static class PetsEndpoints
{
    public static void MapPetsEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/pets").WithTags("Pets");

        group.MapGet("/profile/{id}", (int id) =>
        {
            //return new PetProfile { ID = id };
        })
        .WithName("GetPetProfileById")
        .WithOpenApi();
    }
}