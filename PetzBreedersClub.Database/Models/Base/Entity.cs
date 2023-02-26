#nullable disable
using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.Database.Models.Base;

public abstract class Entity : BaseEntity
{
	[Required]
	public DateTime CreatedDate { get; set; }
	public DateTime? LastModifiedDate { get; set; }

	[Required]
	public string AddedBy { get; set; }
	public string ModifiedBy { get; set; }
}
#nullable enable