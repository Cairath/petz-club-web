using PetzBreedersClub.Database;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.DTOs.StaffDashboard;

namespace PetzBreedersClub.Services;

public interface IStaffService
{
	Task<IResult> GetDashboardSummary();
}

public class StaffService : IStaffService
{
	private readonly Context _context;
	private readonly IUserService _userService;

	public StaffService(Context context, IUserService userService)
	{
		_context = context;
		_userService = userService;
	}

	public async Task<IResult> GetDashboardSummary()
	{
		var pendingAffixesCount = await _context.AffixesPendingRegistration.CountAsync();

		var dashboardSummary = new StaffDashboardSummary
		{
			PendingAffixRegistrations = pendingAffixesCount,
			PendingCatRegistrations = 0,
			PendingDogRegistrations = 0
		};

		return Results.Ok(dashboardSummary);
	}
}