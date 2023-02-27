#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PetzBreedersClub.Database.Models;

[Table("Affixes")]
public class AffixEntity : Entity
{
	[Required]
	public string Name { get; set; }

	[Required]
	public AffixSyntax AffixSyntax { get; set; }

	[Required]
	public int OwnerId { get; set; }
	public virtual MemberEntity Owner { get; set; }
}

public class AffixEntityConfiguration : IEntityTypeConfiguration<AffixEntity>
{
	public void Configure(EntityTypeBuilder<AffixEntity> builder)
	{
		builder
			.Property(a => a.AffixSyntax)
			.HasConversion(new EnumToStringConverter<AffixSyntax>());

		builder
			.HasOne(a => a.Owner)
			.WithMany(o => o.Affixes)
			.HasForeignKey(a => a.OwnerId);
	}
}

public enum AffixSyntax
{
	// Example kennel name (affix): Silver Creek, dog: Buddy
	Prefix, // Silver Creek Buddy
	Suffix, // Buddy Silver Creek
	Names, // Silver Creek's Buddy
	The, // Buddy The Silver Creek
	Of, // Buddy Of Silver Creek
	From, //Buddy From Silver Creek
}
#nullable enable