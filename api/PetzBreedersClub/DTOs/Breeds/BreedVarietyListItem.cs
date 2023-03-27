using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Breeds;

public class BreedVarietyListItem
{
	[Required] public int Id { get; set; }
	[Required] public required string Name { get; set; }
}