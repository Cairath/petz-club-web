using PetzBreedersClub.DTOs.Affixes;
using PetzBreedersClub.Services;

namespace PetzBreedersClub.Endpoints;

public static class AffixEndpoints
{
	public static void MapAffixEndpoints(this IEndpointRouteBuilder routes)
	{
		var group = routes.MapGroup("/api/affixes").WithTags("Affixes");

		group.MapPost("/register", async (AffixRegistrationForm registrationForm, IAffixService affixService) =>
			{
				return await affixService.RegisterAffix(registrationForm);
			})
			.WithName("RegisterAffix")
			.RequireAuthorization()
			.WithOpenApi();
	}
}