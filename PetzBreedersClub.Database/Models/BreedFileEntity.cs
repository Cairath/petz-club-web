#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;

namespace PetzBreedersClub.Database.Models;

[Table("BreedFiles")]
public class BreedFileEntity : Entity
{
	[Required]
	public string Name { get; set; }

	[Required]
	public int BreedId { get; set; }
	public virtual BreedEntity Breed { get; set; }
	
}

public class BreedFileEntityConfiguration : IEntityTypeConfiguration<BreedFileEntity>
{
	public void Configure(EntityTypeBuilder<BreedFileEntity> builder)
	{
		builder
			.HasOne(bf => bf.Breed)
			.WithMany(b => b.BreedFiles)
			.HasForeignKey(bf => bf.BreedId);
	}
}
#nullable enable