using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetzBreedersClub.Database.Models;

[Table("BreedVarieties")]
public class BreedVarietyEntity : Entity
{
	public required string Name { get; set; }

	public int BreedId { get; set; }
	public virtual BreedEntity Breed { get; set; } = null!;
}

public class BreedVarietyEntityConfiguration : IEntityTypeConfiguration<BreedVarietyEntity>
{
	public void Configure(EntityTypeBuilder<BreedVarietyEntity> builder)
	{
		builder
			.HasOne(bv => bv.Breed)
			.WithMany(b => b.Varieties)
			.HasForeignKey(bv => bv.BreedId);
	}
}