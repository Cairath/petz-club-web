using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;

namespace PetzBreedersClub.Database.Models;

[Table("ProfilePics")]
public class ProfilePicEntity : Entity
{
	public required string FileName { get; set; }

	public int PetId { get; set; }
	public virtual PetEntity Pet { get; set; } = null!;

}

public class ProfilePicEntityConfiguration : IEntityTypeConfiguration<ProfilePicEntity>
{
	public void Configure(EntityTypeBuilder<ProfilePicEntity> builder)
	{
		builder
			.HasOne(pp => pp.Pet)
			.WithOne(p => p.ProfilePic)
			.HasForeignKey<ProfilePicEntity>(pp => pp.PetId);
	}
}