#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models;

[Table("Affixes")]
public class AffixEntity : Entity
{
	[Required]
	public string Name { get; set; }

	[Required]
	public AffixSyntax Syntax { get; set; }

	[Required]
	public AffixStatus Status { get; set; }

	[Required]
	public int OwnerId { get; set; }
	public virtual MemberEntity Owner { get; set; }

	public virtual ICollection<PetEntity> Pets { get; set; } = new List<PetEntity>();
}

public class AffixEntityConfiguration : IEntityTypeConfiguration<AffixEntity>
{
	public void Configure(EntityTypeBuilder<AffixEntity> builder)
	{
		builder
			.Property(a => a.Syntax);

		builder
			.HasIndex(a => a.Name).IsUnique();

		builder
			.Property(a => a.Syntax)
			.HasConversion(new EnumToStringConverter<AffixSyntax>());

		builder
			.Property(a => a.Status)
			.HasConversion(new EnumToStringConverter<AffixStatus>());

		builder
			.HasOne(a => a.Owner)
			.WithMany(o => o.Affixes)
			.HasForeignKey(a => a.OwnerId);
	}
}
#nullable enable