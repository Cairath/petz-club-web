using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.StaffDashboard;

public class StaffDashboardSummary
{
	[Required] public int PendingCatRegistrations { get; set; }
	[Required] public int PendingDogRegistrations { get; set; }
	[Required] public int PendingAffixRegistrations { get; set; }
}