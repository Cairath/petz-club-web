using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Affixes;

public class SimilarName
{
	[Required] public int Id { get; set; }
	[Required] public required string Name { get; set; }
	[Required] public AffixSyntax Syntax { get; set; }
	[Required] public int SimilarityPercentage { get; set; }
}