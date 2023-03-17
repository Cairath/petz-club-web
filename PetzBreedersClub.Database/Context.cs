﻿using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database.Models.Base;
using PetzBreedersClub.Database.Models.Seeds;

namespace PetzBreedersClub.Database;

public class Context : IdentityDbContext<UserEntity, IdentityRole<int>, int>
{
	private readonly IHttpContextAccessor _httpContextAccessor;

	public Context(DbContextOptions<Context> options, IHttpContextAccessor httpContextAccessor) : base(options)
	{
		_httpContextAccessor = httpContextAccessor;
	}
	
	public DbSet<MemberEntity> Members { get; set; } = default!;
	public DbSet<BreedEntity> Breeds { get; set; } = default!;
	public DbSet<BreedStandardEntity> BreedStandards { get; set; } = default!;
	public DbSet<PetEntity> Pets { get; set; } = default!;
	public DbSet<ShowEntity> Shows { get; set; } = default!;
	public DbSet<AffixEntity> Affixes { get; set; } = default!;
	public DbSet<SystemNotificationEntity> SystemNotifications { get; set; } = default!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		var dateTimeConverter = new ValueConverter<DateTime, DateTime>(
			v => v.ToUniversalTime(),
			v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

		foreach (var entityType in modelBuilder.Model.GetEntityTypes())
		{
			foreach (var property in entityType.GetProperties())
			{
				if (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?))
				{
					property.SetValueConverter(dateTimeConverter);
				}
			}
		}

		modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

		DogBreedsSeed.Seed(modelBuilder);
	}


	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
	{
		foreach (var entry in ChangeTracker.Entries())
		{
			if (entry.Entity is Entity entity)
			{
				if (entry.State == EntityState.Added)
				{
					entity.AddedBy = _httpContextAccessor.HttpContext?.User?
							.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "system";
					entity.CreatedDate = DateTime.Now;
					continue;
				}

				if (entry.State == EntityState.Modified)
				{
					entity.ModifiedBy = _httpContextAccessor.HttpContext?.User?
						.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value ?? "system";
					entity.LastModifiedDate = DateTime.Now;
				}
			}
		}

		var result = base.SaveChangesAsync(cancellationToken);
		return result;
	}
}