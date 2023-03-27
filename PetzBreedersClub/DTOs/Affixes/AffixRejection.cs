using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Affixes;

public class AffixRejection
{
	[Required] public int Id { get; set; }
	[Required] public required string Reason { get; set; }
}