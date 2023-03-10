#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;

namespace PetzBreedersClub.Database.Models;

[Table("Members")]
public class MemberEntity : Entity
{
	[Required]
	public string Name { get; set; }

	[Required]
	public int UserId { get; set; }
	public virtual UserEntity User { get; set; }
	
	public virtual ICollection<PetEntity> OwnedPets { get; set; } = new List<PetEntity>();
	public virtual ICollection<PetEntity> BredPets { get; set; } = new List<PetEntity>();
	public virtual ICollection<AffixEntity> Affixes { get; set; } = new List<AffixEntity>();
}

public class MemberEntityConfiguration : IEntityTypeConfiguration<MemberEntity>
{
	public void Configure(EntityTypeBuilder<MemberEntity> builder)
	{
		builder
			.HasIndex(m => m.Name).IsUnique();

		builder.HasOne(m => m.User)
			.WithOne(u => u.Member)
			.HasForeignKey<MemberEntity>(m => m.UserId)
			.OnDelete(DeleteBehavior.Cascade);
	}
}
#nullable enable