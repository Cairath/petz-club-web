using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models;

[Table("MonthlyShowPics")]
public class MonthlyShowPicEntity : Entity
{
	public ShowPicType Type { get; set; }
	public DateTime Month { get; set; }
	public required string FileName { get; set; }
	
	public int PetId { get; set; }
	public virtual PetEntity Pet { get; set; } = null!;
}

public class ShowPicEntityConfiguration : IEntityTypeConfiguration<MonthlyShowPicEntity>
{
	public void Configure(EntityTypeBuilder<MonthlyShowPicEntity> builder)
	{
		builder
			.HasOne(sp => sp.Pet)
			.WithMany(p => p.MonthlyShowPics)
			.HasForeignKey(sp => sp.PetId);
	}
}