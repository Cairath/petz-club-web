using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Affixes
{
	public class OwnedAffixes
	{
		[Required] public List<AffixListItem> Registered { get; set; } = new();
		[Required] public List<AffixListItem> Pending { get; set; } = new();
		[Required] public int Owned { get; set; }
		[Required] public int Allowed { get; set; }
	}
}
