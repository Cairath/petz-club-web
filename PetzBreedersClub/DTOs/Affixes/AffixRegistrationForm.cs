using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Affixes
{
    public class AffixRegistrationForm
	{
		[Required] public required string Name { get; set; }
		[Required] public required AffixSyntax Syntax { get; set; }
	}
}
