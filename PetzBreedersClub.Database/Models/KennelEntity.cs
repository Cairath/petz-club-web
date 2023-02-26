using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetzBreedersClub.Database.Models;

[Table("Kennels")]
public class KennelEntity : Entity
{
	public required string Name { get; set; }
}

public class KennelEntityConfiguration : IEntityTypeConfiguration<KennelEntity>
{
	public void Configure(EntityTypeBuilder<KennelEntity> builder)
	{

	}
}
