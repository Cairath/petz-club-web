using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzBreedersClub.Database.Models.Base;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models;

[Table("Pets")]
public class PetEntity : Entity
{
	public required string ShowName { get; set; }
	public required string PartialShowName { get; set; }
	public required string CallName { get; set; }
	public required string PedigreeNumber { get; set; }
	public Age Age { get; set; }
	public Sex Sex { get; set; }
	public GameVersion GameVersion { get; set; }
	public PetStatus Status { get; set; }
	public DateTime? RegistrationDate { get; set; }

	public int BreedId { get; set; }
	public virtual BreedEntity Breed { get; set; } = null!;

	public int AffixId { get; set; }
	public virtual AffixEntity Affix { get; set; } = null!;

	public int OwnerId { get; set; }
	public virtual MemberEntity Owner { get; set; } = null!;

	public int BreederId { get; set; }
	public virtual MemberEntity Breeder { get; set; } = null!;

	public int? DamId { get; set; }
	public virtual PetEntity Dam { get; set; } = null!;

	public int? SireId { get; set; }
	public virtual PetEntity Sire { get; set; } = null!;

	public virtual ICollection<PetEntity> Offspring { get; set; } = new List<PetEntity>();

	public int? RegistrarId { get; set; }
	public virtual MemberEntity Registrar { get; set; } = null!;
}

public class PetEntityConfiguration : IEntityTypeConfiguration<PetEntity>
{
	public void Configure(EntityTypeBuilder<PetEntity> builder)
	{
		builder
			.HasIndex(p => p.PedigreeNumber).IsUnique();

		builder
			.Property(p => p.Age)
			.HasConversion(new EnumToStringConverter<Age>());

		builder
			.Property(p => p.Sex)
			.HasConversion(new EnumToStringConverter<Sex>());

		builder
			.Property(p => p.Status)
			.HasConversion(new EnumToStringConverter<PetStatus>());

		builder
			.Property(p => p.GameVersion)
			.HasConversion(new EnumToStringConverter<GameVersion>());

		builder
			.HasOne(p => p.Breed)
			.WithMany()
			.HasForeignKey(p => p.BreedId);

		builder
			.HasOne(p => p.Affix)
			.WithMany(a => a.Pets)
			.HasForeignKey(p => p.AffixId);

		builder
			.HasOne(p => p.Owner)
			.WithMany(o => o.OwnedPets)
			.HasForeignKey(p => p.OwnerId)
			.OnDelete(DeleteBehavior.NoAction);

		builder
			.HasOne(p => p.Breeder)
			.WithMany(b => b.BredPets)
			.HasForeignKey(p => p.BreederId)
			.OnDelete(DeleteBehavior.NoAction);

		builder
			.HasOne(p => p.Dam)
			.WithMany()
			.HasForeignKey(p => p.DamId)
			.OnDelete(DeleteBehavior.NoAction)
			.IsRequired(false);

		builder
			.HasOne(p => p.Sire)
			.WithMany()
			.HasForeignKey(p => p.SireId)
			.OnDelete(DeleteBehavior.NoAction)
			.IsRequired(false);

		builder
			.HasMany(p => p.Offspring)
			.WithMany()
			.UsingEntity<Dictionary<string, object>>(
				"Offspring",
				o => o.HasOne<PetEntity>().WithMany().HasForeignKey("ChildId"),
				o => o.HasOne<PetEntity>().WithMany().HasForeignKey("ParentId"));

		builder
			.HasOne(p => p.Registrar)
			.WithMany()
			.HasForeignKey(p => p.RegistrarId)
			.OnDelete(DeleteBehavior.NoAction)
			.IsRequired(false);
	}
}