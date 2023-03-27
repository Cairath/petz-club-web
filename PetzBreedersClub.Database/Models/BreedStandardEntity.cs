#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetzBreedersClub.Database.Models;

[Table("BreedStandards")]
public class BreedStandardEntity : Entity
{
	[Required]
	public string Coat { get; set; }

	[Required]
	public string Eyes { get; set; }

	[Required]
	public string Nose { get; set; }

	public string Faults { get; set; }
	public string DisqualifyingFaults { get; set; }
	public string Notes { get; set; }

	[Required]
	public int BreedId { get; set; }
	public virtual BreedEntity Breed { get; set; }
}

public class BreedStandardEntityConfiguration : IEntityTypeConfiguration<BreedStandardEntity>
{
	public void Configure(EntityTypeBuilder<BreedStandardEntity> builder)
	{

		builder
			.HasOne(bs => bs.Breed)
			.WithOne(b => b.BreedStandard)
			.HasForeignKey<BreedStandardEntity>(bs => bs.BreedId);
	}
}

#nullable enable