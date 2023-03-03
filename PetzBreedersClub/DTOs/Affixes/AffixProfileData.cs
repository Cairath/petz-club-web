using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Affixes
{
	public class AffixProfileData
	{
		[Required] public int Id { get; set; }
		[Required] public string Name { get; set; }
		[Required] public int OwnerId { get; set; }
		[Required] public string OwnerName { get; set; }
	}
}
