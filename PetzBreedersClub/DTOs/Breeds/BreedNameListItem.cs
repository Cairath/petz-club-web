using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Breeds;

public class BreedNameListItem
{
	[Required] public int Id { get; set; }
	[Required] public required string Name { get; set; }
	[Required] public int Group { get; set; }
	[Required] public int Section { get; set; }
}