namespace PetzBreedersClub.Endpoints;

public static class PetEndpoints
{
    public static void MapPetsEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/pets").WithTags("Pets");

        group.MapGet("/profile/{id}", () =>
        {
           
        })
        .WithName("GetPetProfileById")
        .WithOpenApi();
    }
}