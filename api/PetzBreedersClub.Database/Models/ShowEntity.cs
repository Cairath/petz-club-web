using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzBreedersClub.Database.Models.Base;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models;

[Table("Shows")]
public class ShowEntity : Entity
{
	public required string Name { get; set; }
	public ShowType Type { get; set; }


	public int JudgeId { get; set; }
	public virtual MemberEntity Judge { get; set; } = null!;

	public virtual ICollection<ShowEntryEntity> ShowEntries { get; set; } = null!;
}

public class ShowEntityConfiguration : IEntityTypeConfiguration<ShowEntity>
{
	public void Configure(EntityTypeBuilder<ShowEntity> builder)
	{
		builder
			.HasOne(s => s.Judge)
			.WithMany()
			.HasForeignKey(s => s.JudgeId);

		builder
			.Property(s => s.Type)
			.HasConversion(new EnumToStringConverter<ShowType>());
	}
}