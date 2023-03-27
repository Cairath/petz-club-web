using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Pets;

public class BreedingAvailability
{
	[Required] public int PetId { get; set; }
	[Required] public bool IsAvailable { get; set; }
}