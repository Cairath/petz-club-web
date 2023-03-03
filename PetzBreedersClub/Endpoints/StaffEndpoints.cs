using PetzBreedersClub.DTOs.StaffDashboard;
using PetzBreedersClub.Services;

namespace PetzBreedersClub.Endpoints;

public static class StaffEndpoints
{
	public static void MapStaffEndpoints(this IEndpointRouteBuilder routes)
	{
		var group = routes.MapGroup("/api/staff").WithTags("Staff");

		group.MapGet("/dashboard", async (IStaffService staffService) =>
			{
				return await staffService.GetDashboardSummary();
			})
			.WithName("GetStaffDashboard")
			.RequireAuthorization()
			.Produces<StaffDashboardSummary>()
			.WithOpenApi();
	}
}
