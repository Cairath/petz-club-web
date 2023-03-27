using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Pets;

public class SetPetActiveStatus
{
	[Required] public required int PetId { get; set; }
	[Required] public bool Active { get; set; }
}