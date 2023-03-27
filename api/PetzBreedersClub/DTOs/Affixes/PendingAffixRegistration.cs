using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Affixes;

public class PendingAffixRegistration
{
	[Required] public int Id { get; set; }
	[Required] public required string Name { get; set; }
	[Required] public AffixSyntax Syntax { get; set; }
	[Required] public int OwnerId { get; set; }
	[Required] public required string OwnerName { get; set; }
	[Required] public required List<SimilarName> SimilarNames { get; set; }
	[Required] public DateTime SubmissionDate { get; set; }
}
