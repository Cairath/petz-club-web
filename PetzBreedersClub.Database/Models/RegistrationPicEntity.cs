using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;

namespace PetzBreedersClub.Database.Models;

[Table("RegistrationPics")]
public class RegistrationPicEntity : Entity
{
	public required string FileName { get; set; }

	public int PetId { get; set; }
	public virtual PetEntity Pet { get; set; } = null!;

}

public class RegistrationPicEntityConfiguration : IEntityTypeConfiguration<RegistrationPicEntity>
{
	public void Configure(EntityTypeBuilder<RegistrationPicEntity> builder)
	{
		builder
			.HasOne(rp => rp.Pet)
			.WithOne(p => p.RegistrationPic)
			.HasForeignKey<RegistrationPicEntity>(rp => rp.PetId);
	}
}