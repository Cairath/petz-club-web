using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using PetzBreedersClub.Database.Models.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PetzBreedersClub.Database.Models;

[Table("Breeds")]
public class BreedEntity : Entity
{
	public required string Name { get; set; }
	public Species Species { get; set; }
	public int Group { get; set; }
	public int Section { get; set; }
	
	public int? BreedStandardId { get; set; }
	public virtual BreedStandardEntity? BreedStandard { get; set; }

	public virtual ICollection<BreedFileEntity> BreedFiles { get; set; } = new List<BreedFileEntity>();
	public virtual ICollection<BreedVarietyEntity> Varieties { get; set; } = new List<BreedVarietyEntity>();
}

public class BreedEntityConfiguration : IEntityTypeConfiguration<BreedEntity>
{
	public void Configure(EntityTypeBuilder<BreedEntity> builder)
	{
		//builder
		//	.HasIndex(b => b.Name).IsUnique();

		builder
			.Property(b => b.Species)
			.HasConversion(new EnumToStringConverter<Species>());
	}
}