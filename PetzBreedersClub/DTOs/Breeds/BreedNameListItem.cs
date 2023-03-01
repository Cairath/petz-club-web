using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Breeds;

public class BreedNameListItem
{
	[Required] public required int Id { get; set; }
	[Required] public required string Name { get; set; }
	[Required] public required Species Species { get; set; }
}