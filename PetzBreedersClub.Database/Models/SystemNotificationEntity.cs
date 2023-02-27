#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using PetzBreedersClub.Database.Models.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PetzBreedersClub.Database.Models;

[Table("SystemNotifications")]
public class SystemNotificationEntity : Entity
{
	[Required]
	public string Text { get; set; }

	[Required]
	public NotificationType Type { get; set; }

	[Required]
	public bool Read { get; set; }

	[Required]
	public int UserId { get; set; }
	public virtual UserEntity User { get; set; }
}

public class SystemNotificationEntityConfiguration : IEntityTypeConfiguration<SystemNotificationEntity>
{
	public void Configure(EntityTypeBuilder<SystemNotificationEntity> builder)
	{
		builder
			.HasOne(sn => sn.User)
			.WithMany(u => u.SystemNotifications)
			.HasForeignKey(sn => sn.UserId);

		builder
			.Property(sn => sn.Type)
			.HasConversion(new EnumToStringConverter<NotificationType>());
	}
}

#nullable enable