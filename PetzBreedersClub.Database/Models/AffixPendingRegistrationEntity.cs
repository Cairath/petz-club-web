#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models;

[Table("AffixesPendingRegistration")]
public class AffixPendingRegistrationEntity : Entity
{
	[Required]
	public string Name { get; set; }

	[Required]
	public AffixSyntax Syntax { get; set; }

	[Required]
	public RegistrationStatus RegistrationStatus { get; set; }

	[Required]
	public int OwnerId { get; set; }
	public virtual MemberEntity Owner { get; set; }
}

public class AffixPendingRegistrationEntityConfiguration : IEntityTypeConfiguration<AffixPendingRegistrationEntity>
{ 
	public void Configure(EntityTypeBuilder<AffixPendingRegistrationEntity> builder)
	{
		builder
			.Property(a => a.Syntax);

		builder
			.HasIndex(a => a.Name).IsUnique();

		builder
			.Property(a => a.Syntax)
			.HasConversion(new EnumToStringConverter<AffixSyntax>());

		builder
			.Property(a => a.RegistrationStatus)
			.HasConversion(new EnumToStringConverter<RegistrationStatus>());

		builder
			.HasOne(a => a.Owner)
			.WithMany(o => o.AffixesPendingRegistration)
			.HasForeignKey(a => a.OwnerId);
	}
}

#nullable enable