using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Pets;

public class PetProfileData
{
	[Required] public int Id { get; set; }
	[Required] public required string ShowName { get; set; }
	[Required] public required string PedigreeNumber { get; set; }
	[Required] public required DateTime RegistrationDate { get; set; }
	[Required] public Age Age { get; set; }
	[Required] public Sex Sex { get; set; }
	[Required] public GameVersion GameVersion { get; set; }
	[Required] public PetStatus Status { get; set; }
	[Required] public bool IsAvailableForBreeding { get; set; }
	[Required] public int BreedId { get; set; }
	[Required] public required string BreedName { get; set; }
	[Required] public int OwnerId { get; set; }
	[Required] public required string OwnerName { get; set; }
	[Required] public int BreederId { get; set; }
	[Required] public required string BreederName { get; set; }
	[Required] public int AffixId { get; set; }
	[Required] public required string AffixName { get; set; }
	[Required] public Pedigree? Pedigree { get; set; }
	[Required] public List<PetLink>? Offspring { get; set; }
	[Required] public List<SiblingLink>? Siblings { get; set; }
}