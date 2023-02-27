#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzBreedersClub.Database.Models.Base;

namespace PetzBreedersClub.Database.Models;

[Table("Pets")]
public class PetEntity : Entity
{
	[Required]
	public string ShowName { get; set; }

	[Required]
	public string CallName { get; set; }

	[Required]
	public string PedigreeNumber { get; set; }

	[Required]
	public Age Age { get; set; }

	[Required]
	public int BreedId { get; set; }
	public virtual BreedEntity Breed { get; set; }

	[Required]
	public int OwnerId { get; set; }
	public virtual MemberEntity Owner { get; set; }

	[Required]
	public int BreederId { get; set; }
	public virtual MemberEntity Breeder { get; set; }
	
	public int DamId { get; set; }
	public virtual PetEntity Dam { get; set; }

	public int SireId { get; set; }
	public virtual PetEntity Sire { get; set; }
	

	public virtual ICollection<PetEntity> Offspring { get; set; } = new List<PetEntity>();
}

public class PetEntityConfiguration : IEntityTypeConfiguration<PetEntity>
{
	public void Configure(EntityTypeBuilder<PetEntity> builder)
	{
		builder
			.HasIndex(p => p.PedigreeNumber).IsUnique();

		builder
			.Property(p=>p.Age)
			.HasConversion(new EnumToStringConverter<Age>());

		builder
			.HasOne(p => p.Breed)
			.WithMany()
			.HasForeignKey(p => p.BreedId);

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
			.OnDelete(DeleteBehavior.NoAction);

		builder
			.HasOne(p => p.Sire)
			.WithMany()
			.HasForeignKey(p => p.SireId)
			.OnDelete(DeleteBehavior.NoAction);

		builder
			.HasMany(p => p.Offspring)
			.WithMany()
			.UsingEntity<Dictionary<string, object>>(
				"Offspring",
				o => o.HasOne<PetEntity>().WithMany().HasForeignKey("ChildId"),
				o => o.HasOne<PetEntity>().WithMany().HasForeignKey("ParentId"));
	}
}

public enum Age
{
	Junior,
	Adult
}
#nullable enable