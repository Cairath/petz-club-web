using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;

namespace PetzBreedersClub.Database.Models;

[Table("ShowEntries")]
public class ShowEntryEntity : Entity
{
	public required string FileName { get; set; }

	public int ShowId { get; set; }
	public virtual ShowEntity Show { get; set; } = null!;

	public int PetId { get; set; }
	public virtual PetEntity Pet { get; set; } = null!;
}

public class ShowEntryEntityConfiguration : IEntityTypeConfiguration<ShowEntryEntity>
{
	public void Configure(EntityTypeBuilder<ShowEntryEntity> builder)
	{
		builder
			.HasOne(se => se.Show)
			.WithMany(s => s.ShowEntries)
			.HasForeignKey(se => se.ShowId)
			.OnDelete(DeleteBehavior.Restrict);

		builder
			.HasOne(se => se.Pet)
			.WithMany(p => p.ShowEntries)
			.HasForeignKey(se => se.PetId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}