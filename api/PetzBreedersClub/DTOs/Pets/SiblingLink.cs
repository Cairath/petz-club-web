using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Pets;

public class SiblingLink
{
	[Required] public int Id { get; set; }
	[Required] public required string ShowName { get; set; }
	[Required] public Sex Sex { get; set; }
	[Required] public bool Full { get; set; }
}