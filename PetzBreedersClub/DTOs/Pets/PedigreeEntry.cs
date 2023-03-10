using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Pets;

public class PedigreeEntry
{
	[Required] public int Id { get; set; }
	[Required] public required string ShowName { get; set; }
	[Required] public required string PedigreeNumber { get; set; }
}