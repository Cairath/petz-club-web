#nullable disable
using System.ComponentModel.DataAnnotations;
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
	[Required]
	public string Name { get; set; }

	[Required]
	public Species Species { get; set; }

	public virtual BreedStandardEntity BreedStandard { get; set; }
	public virtual ICollection<BreedFileEntity> BreedFiles { get; set; } = new List<BreedFileEntity>();
}

public class BreedEntityConfiguration : IEntityTypeConfiguration<BreedEntity>
{
	public void Configure(EntityTypeBuilder<BreedEntity> builder)
	{
		builder
			.HasIndex(b => b.Name).IsUnique();

		builder
			.Property(b => b.Species)
			.HasConversion(new EnumToStringConverter<Species>());
	}
}
#nullable enable