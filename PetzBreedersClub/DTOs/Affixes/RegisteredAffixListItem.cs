using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Affixes;

public class RegisteredAffixListItem
{
	[Required] public int Id { get; set; }
	[Required] public required string Name { get; set; }
	[Required] public required int PetsCount { get; set; }
	[Required] public AffixSyntax Syntax { get; set; }

	[Required] public DateTime RegistrationDate { get; set; }
	[Required] public AffixStatus Status { get; set; }
}