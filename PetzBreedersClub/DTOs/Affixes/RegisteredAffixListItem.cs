using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Affixes
{
	public class RegisteredAffixListItem
	{
		[Required] public required string Name { get; set; }

		[Required] public AffixSyntax Syntax { get; set; }

		[Required] public DateTime RegistrationDate { get; set; }
	}
}
