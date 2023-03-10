using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Pets;

public class PetProfileData
{
	[Required] public int Id { get; set; }
	[Required] public required string ShowName { get; set; }
}