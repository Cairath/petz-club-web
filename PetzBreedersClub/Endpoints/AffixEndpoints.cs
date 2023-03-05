using Microsoft.AspNetCore.Mvc;
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

		group.MapGet("/pending", async (IAffixService affixService) =>
			{
				return await affixService.GetPendingAffixRegistrations();
			})
			.WithName("GetPendingAffixRegistrations")
			.RequireAuthorization(/*registrar*/)
			.Produces<List<PendingAffixRegistration>>()
			.WithOpenApi();

		group.MapPost("/approve", async ([FromBody] int pendingAffixId, IAffixService affixService) =>
			{
				return await affixService.ApproveAffix(pendingAffixId);
			})
			.WithName("ApprovePendingAffixRegistration")
			.RequireAuthorization(/*registrar*/)
			.WithOpenApi();

		group.MapPost("/reject", async (AffixRejection affixRejection, IAffixService affixService) =>
			{
				return await affixService.RejectAffix(affixRejection);
			})
			.WithName("RejectPendingAffixRegistration")
			.RequireAuthorization(/*registrar*/)
			.WithOpenApi();


	}
}
