using PetzBreedersClub.Database;
using PetzBreedersClub.DTOs.Affixes;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Caching.Memory;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database.Models.Enums;
using PetzBreedersClub.DTOs.Pets;

namespace PetzBreedersClub.Services;

public interface IPetService
{
	Task<IResult> GetPetProfile(int petId);
	Task<IResult> GetPedigree(int petId, int generations);
}

public class PetService : IPetService
{
	private readonly Context _context;
	private readonly IUserService _userService;
	private readonly IMemoryCache _cache;
	private readonly AffixRegistrationFormValidator _affixRegistrationFormValidator;

	public PetService(Context context, IUserService userService, IMemoryCache cache, AffixRegistrationFormValidator affixRegistrationFormValidator)
	{
		_context = context;
		_userService = userService;
		_cache = cache;
		_affixRegistrationFormValidator = affixRegistrationFormValidator;
	}

	public async Task<IResult> GetPetProfile(int petId)
	{
		var affixProfile =
			await _context.Pets
				.Where(p => p.Id == petId && p.Status != PetStatus.PendingRegistration)
				.Select(p => new PetProfileData
				{
					Id = p.Id,
					ShowName = p.ShowName
				}).FirstOrDefaultAsync();

		return affixProfile == null ? Results.NotFound() : Results.Ok(affixProfile);
	}



	public async Task<IResult> GetPedigree(int petId, int generations)
	{
		var pedigreeEntries = new List<List<PedigreeEntry?>>();
		var familyTree = new List<List<PetEntity?>>();

		var ancestors = await GetAncestors(petId, generations);

		if (ancestors.Count == 0)
		{
			return Results.NotFound();
		}

		for (var i = 0; i < generations; i++)
		{
			familyTree.Add(new List<PetEntity?>());
		}
		
		var pet = ancestors.First(p => p.Id == petId);

		for (var i = 0; i < generations; i++)
		{
			if (i == 0)
			{
				var sire = pet.Sire;
				var dam = pet.Dam;

				familyTree[0].Add(sire);
				familyTree[0].Add(dam);
				
				continue;
			}

			foreach (var p in familyTree[i - 1])
			{
				var sire = p?.Sire;
				var dam = p?.Dam;

				familyTree[i].Add(sire);
				familyTree[i].Add(dam);
				
			}
		}

		foreach (var generation in familyTree)
		{
			var pedigreeGen = new List<PedigreeEntry?>();

			foreach (var entry in generation)
			{
				var pedigreeEntry = entry != null
					? new PedigreeEntry
					{ Id = entry.Id, PedigreeNumber = entry.PedigreeNumber, ShowName = entry.ShowName }
					: null;

				pedigreeGen.Add(pedigreeEntry);
			}

			pedigreeEntries.Add(pedigreeGen);
		}


		return Results.Ok(new Pedigree { Entries = pedigreeEntries });
	}

	private Task<List<PetEntity>> GetAncestors(int petId, int generations)
	{
		return _context.Pets.FromSqlRaw(@$"
					WITH Ancestors (
					    {nameof(PetEntity.Id)}, 
					    {nameof(PetEntity.ShowName)}, 
					    {nameof(PetEntity.PartialShowName)}, 
					    {nameof(PetEntity.CallName)}, 
					    {nameof(PetEntity.PedigreeNumber)}, 
					    {nameof(PetEntity.Age)}, 
					    {nameof(PetEntity.Status)}, 
					    {nameof(PetEntity.SireId)}, 
					    {nameof(PetEntity.DamId)}, 
					    {nameof(PetEntity.AffixId)}, 
					    {nameof(PetEntity.BreedId)}, 
					    {nameof(PetEntity.OwnerId)}, 
					    {nameof(PetEntity.BreedId)}, 
					    {nameof(PetEntity.CreatedDate)}, 
					    {nameof(PetEntity.AddedBy)}, 
					    {nameof(PetEntity.LastModifiedDate)}, 
					    {nameof(PetEntity.ModifiedBy)}, 
					    Depth
					) AS (
					    SELECT 
						    {nameof(PetEntity.Id)}, 
						    {nameof(PetEntity.ShowName)}, 
						    {nameof(PetEntity.PartialShowName)}, 
						    {nameof(PetEntity.CallName)}, 
						    {nameof(PetEntity.PedigreeNumber)}, 
						    {nameof(PetEntity.Age)}, 
						    {nameof(PetEntity.Status)}, 
						    {nameof(PetEntity.SireId)}, 
						    {nameof(PetEntity.DamId)}, 
						    {nameof(PetEntity.AffixId)}, 
						    {nameof(PetEntity.BreedId)}, 
						    {nameof(PetEntity.OwnerId)}, 
						    {nameof(PetEntity.BreedId)}, 
						    {nameof(PetEntity.CreatedDate)}, 
						    {nameof(PetEntity.AddedBy)}, 
						    {nameof(PetEntity.LastModifiedDate)}, 
						    {nameof(PetEntity.ModifiedBy)}, 
					        0
					    FROM dbo.Pets
					    WHERE Id = {0}

					    UNION ALL

					    SELECT 
					        p.{nameof(PetEntity.Id)}, 
					        p.{nameof(PetEntity.ShowName)}, 
					        p.{nameof(PetEntity.PartialShowName)}, 
					        p.{nameof(PetEntity.CallName)}, 
					        p.{nameof(PetEntity.PedigreeNumber)}, 
					        p.{nameof(PetEntity.Age)}, 
					        p.{nameof(PetEntity.Status)}, 
					        p.{nameof(PetEntity.SireId)}, 
					        p.{nameof(PetEntity.DamId)}, 
					        p.{nameof(PetEntity.AffixId)}, 
					        p.{nameof(PetEntity.BreedId)}, 
					        p.{nameof(PetEntity.OwnerId)}, 
					        p.{nameof(PetEntity.BreedId)}, 
					        p.{nameof(PetEntity.CreatedDate)}, 
					        p.{nameof(PetEntity.AddedBy)}, 
					        p.{nameof(PetEntity.LastModifiedDate)},  
					        p.{nameof(PetEntity.ModifiedBy)}, 
					        pa.Depth + 1
					    FROM 
					        dbo.Pets AS p
					        INNER JOIN Ancestors AS pa ON p.{nameof(PetEntity.Id)} = pa.{nameof(PetEntity.SireId)}

					    UNION ALL

					    SELECT 
					        p.{nameof(PetEntity.Id)}, 
					        p.{nameof(PetEntity.ShowName)}, 
					        p.{nameof(PetEntity.PartialShowName)}, 
					        p.{nameof(PetEntity.CallName)}, 
					        p.{nameof(PetEntity.PedigreeNumber)}, 
					        p.{nameof(PetEntity.Age)}, 
					        p.{nameof(PetEntity.Status)}, 
					        p.{nameof(PetEntity.SireId)}, 
					        p.{nameof(PetEntity.DamId)}, 
					        p.{nameof(PetEntity.AffixId)}, 
					        p.{nameof(PetEntity.BreedId)}, 
					        p.{nameof(PetEntity.OwnerId)}, 
					        p.{nameof(PetEntity.BreedId)}, 
					        p.{nameof(PetEntity.CreatedDate)}, 
					        p.{nameof(PetEntity.AddedBy)}, 
					        p.{nameof(PetEntity.LastModifiedDate)}, 
					        p.{nameof(PetEntity.ModifiedBy)}, 
					        pa.Depth + 1
					    FROM 
					        dbo.Pets AS p
					        INNER JOIN Ancestors AS pa ON p.{nameof(PetEntity.Id)} = pa.{nameof(PetEntity.DamId)}
					)
					SELECT * FROM Ancestors WHERE Depth <= {1}", petId, generations)
			.AsNoTrackingWithIdentityResolution()
			.ToListAsync();
	}
}