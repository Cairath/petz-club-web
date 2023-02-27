using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Breeds;

public class BreedNameListItem
{
	public required int Id { get; set; }
	public required string Name { get; set; }
	public required Species Species { get; set; }
}