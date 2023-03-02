using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Affixes
{
	public class OwnedAffixes
	{
		[Required] public List<RegisteredAffixListItem> Registered { get; set; } = new();
		[Required] public List<RegisteredAffixListItem> Pending { get; set; } = new();
		[Required] public int Owned { get; set; }
		[Required] public int Allowed { get; set; }
	}
}
