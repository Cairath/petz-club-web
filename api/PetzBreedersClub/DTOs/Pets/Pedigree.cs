using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Pets;

public class Pedigree
{
	[Required] public required List<List<PedigreeEntry?>> Entries { get; set; }
}