#nullable disable
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace PetzBreedersClub.Database.Models;

public class UserEntity : IdentityUser<int>
{
	[Required]
	public override string Email { get; set; }

	public virtual MemberEntity Member { get; set; }
	public virtual ICollection<SystemNotificationEntity> SystemNotifications { get; set; } = new List<SystemNotificationEntity>();
}

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
	public void Configure(EntityTypeBuilder<UserEntity> builder)
	{
		builder
			.HasIndex(u => u.Email).IsUnique();
	}
}
#nullable enable