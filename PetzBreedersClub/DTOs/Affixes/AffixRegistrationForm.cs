using PetzBreedersClub.Database.Models;

namespace PetzBreedersClub.DTOs.Affixes
{
	public class AffixRegistrationForm
	{
		public required string Name { get; set; }
		public required AffixSyntax AffixSyntax { get; set; }
	}
}
