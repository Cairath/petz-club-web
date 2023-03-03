using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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

		group.MapGet("/owned", async (IAffixService affixService) =>
			{
				return await affixService.GetOwnedAffixes();
			})
			.WithName("GetOwnedAffixes")
			.RequireAuthorization()
			.Produces<OwnedAffixes>()
			.WithOpenApi();

		group.MapPost("/cancel-registration", async ([FromBody] int pendingAffixId, IAffixService affixService) =>
			{
				return await affixService.CancelPendingAffixRegistration(pendingAffixId);
			})
			.WithName("CancelPendingAffixRegistration")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapGet("/{affixId}", async (int affixId, IAffixService affixService) =>
			{
				return await affixService.GetAffixProfile(affixId);
			})
			.WithName("GetAffixProfile")
			.Produces<AffixProfileData>()
			.WithOpenApi();
	}
}
