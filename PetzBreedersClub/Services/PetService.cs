using PetzBreedersClub.Database;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database.Models.Enums;
using PetzBreedersClub.DTOs.Pets;

namespace PetzBreedersClub.Services;

public interface IPetService
{
	Task<IResult> GetPetProfile(int petId);
	Task<IResult> GetPedigree(int petId, int generations);
	Task<IResult> GetPets(PetListRequest request);
	Task<IResult> SetAdult(int petId);
	Task<IResult> SetBreedingAvailability(BreedingAvailability breedingAvailability);
	Task<IResult> SetStatus(SetPetActiveStatus petActiveStatus);
	Task<IResult> SetBio(SetBioForm setBioForm);
	Task<IResult> UploadProfilePic(int petId, IFormFile file);
	Task<IResult> DeleteProfilePic(int petId);
}

public class PetService : IPetService
{
	private readonly Context _context;
	private readonly IUserService _userService;
	private readonly IMemoryCache _cache;
	private readonly EditBioFormValidator _editEditBioFormValidator;

	public PetService(Context context, IUserService userService, IMemoryCache cache, EditBioFormValidator editEditBioFormValidator)
	{
		_context = context;
		_userService = userService;
		_cache = cache;
		_editEditBioFormValidator = editEditBioFormValidator;
	}

	public async Task<IResult> GetPetProfile(int petId)
	{
		var petData =
			await _context.Pets
				.Include(p => p.Offspring)
				.Include(p => p.Affix)
				.Include(p => p.Breed)
				.Include(p => p.Owner)
				.Include(p => p.Breeder)
				.Include(p => p.RegistrationPic)
				.Include(p => p.ProfilePic).DefaultIfEmpty()
				.Where(p => p.Id == petId && p.Status != PetStatus.PendingRegistration)
				.Select(p => new
				{
					Id = p.Id,
					ShowName = p.ShowName,
					CallName = p.CallName,
					Bio = p.Bio,
					RegistrationPic = p.RegistrationPic.FileName,
					ProfilePic = p.ProfilePic != null ? p.ProfilePic.FileName : null,
					AffixId = p.AffixId,
					AffixName = p.Affix.Name,
					PedigreeNumber = p.PedigreeNumber,
					RegistrationDate = p.RegistrationDate,
					Age = p.Age,
					Sex = p.Sex,
					GameVersion = p.GameVersion,
					IsAvailableForBreeding = p.IsAvailableForBreeding,
					Status = p.Status,
					BreedId = p.BreedId,
					BreedName = p.Breed.Name,
					OwnerId = p.OwnerId,
					OwnerName = p.Owner.Name,
					BreederId = p.BreederId,
					BreederName = p.Breeder.Name,
					Offspring = p.Offspring.Select(o => new PetLink { Id = o.Id, ShowName = o.ShowName, Sex = o.Sex }).ToList(),
					SiblingsDam = p.Dam.Offspring.Where(o => o.Id != petId).Select(o => new SiblingLink { Id = o.Id, ShowName = o.ShowName, Sex = o.Sex }).ToList(),
					SiblingsSire = p.Sire.Offspring.Where(o => o.Id != petId).Select(o => new SiblingLink { Id = o.Id, ShowName = o.ShowName, Sex = o.Sex }).ToList()
				}).FirstOrDefaultAsync();

		if (petData == null)
		{
			return Results.NotFound();
		}

		var siblings = petData.SiblingsDam.UnionBy(petData.SiblingsSire, s => s.Id).ToList();

		foreach (var sibling in siblings)
		{
			if (petData.SiblingsDam.Any(sd => sd.Id == sibling.Id) && petData.SiblingsSire.Any(sd => sd.Id == sibling.Id))
			{
				sibling.Full = true;
			}
		}

		var petProfile = new PetProfileData
		{
			Id = petData.Id,
			ShowName = petData.ShowName,
			CallName = petData.CallName,
			AffixId = petData.AffixId,
			AffixName = petData.AffixName,
			Bio = petData.Bio,
			RegistrationPicture = petData.RegistrationPic,
			ProfilePicture = petData.ProfilePic,
			PedigreeNumber = petData.PedigreeNumber,
			RegistrationDate = petData.RegistrationDate!.Value,
			Age = petData.Age,
			Sex = petData.Sex,
			GameVersion = petData.GameVersion,
			IsAvailableForBreeding = petData.IsAvailableForBreeding,
			Status = petData.Status,
			BreedId = petData.BreedId,
			BreedName = petData.BreedName,
			OwnerId = petData.OwnerId,
			OwnerName = petData.OwnerName,
			BreederId = petData.BreederId,
			BreederName = petData.BreederName,
			Offspring = petData.Offspring,
			Siblings = siblings,
			Pedigree = await GetPedigreeData(petId, 3)
		};

		return Results.Ok(petProfile);
	}

	public async Task<IResult> GetPets(PetListRequest request)
	{
		var petsQueryable =
			_context.Pets
				.Include(p => p.Offspring)
				.Include(p => p.Affix)
				.Include(p => p.Breed)
				.Include(p => p.Owner)
				.Include(p => p.Breeder)
				.Where(p => p.Status != PetStatus.PendingRegistration)
				.Select(p => new PetListItem
				{
					Id = p.Id,
					ShowName = p.ShowName,
					AffixId = p.AffixId,
					AffixName = p.Affix.Name,
					PedigreeNumber = p.PedigreeNumber,
					Age = p.Age,
					Sex = p.Sex,
					Status = p.Status,
					GameVersion = p.GameVersion,
					BreedId = p.BreedId,
					BreedName = p.Breed.Name,
					OwnerId = p.OwnerId,
					OwnerName = p.Owner.Name,
					Species = p.Breed.Species
				}).AsQueryable();

		if (request.ShowName != null && !string.IsNullOrEmpty(request.ShowName))
		{
			petsQueryable = petsQueryable.Where(p => p.ShowName.Contains(request.ShowName));
		}

		if (request.AffixId != null)
		{
			petsQueryable = petsQueryable.Where(p => p.AffixId == request.AffixId);
		}

		if (request.AffixName != null && !string.IsNullOrEmpty(request.AffixName))
		{
			petsQueryable = petsQueryable.Where(p => p.AffixName.Contains(request.AffixName));
		}

		if (request.PedigreeNumber != null && !string.IsNullOrEmpty(request.PedigreeNumber))
		{
			petsQueryable = petsQueryable.Where(p => p.PedigreeNumber.Contains(request.PedigreeNumber));
		}

		if (request.Age != null)
		{
			petsQueryable = petsQueryable.Where(p => p.Age == request.Age);
		}

		if (request.Sex != null)
		{
			petsQueryable = petsQueryable.Where(p => p.Sex == request.Sex);
		}

		if (request.Status != null)
		{
			petsQueryable = petsQueryable.Where(p => p.Status == request.Status);
		}

		if (request.GameVersion != null)
		{
			petsQueryable = petsQueryable.Where(p => p.GameVersion == request.GameVersion);
		}

		if (request.BreedId != null)
		{
			petsQueryable = petsQueryable.Where(p => p.BreedId == request.BreedId);
		}

		if (request.BreedName != null && !string.IsNullOrEmpty(request.BreedName))
		{
			petsQueryable = petsQueryable.Where(p => p.BreedName.Contains(request.BreedName));
		}

		if (request.OwnerId != null)
		{
			petsQueryable = petsQueryable.Where(p => p.OwnerId == request.OwnerId);
		}

		if (request.OwnerName != null && !string.IsNullOrEmpty(request.OwnerName))
		{
			petsQueryable = petsQueryable.Where(p => p.OwnerName.Contains(request.OwnerName));
		}

		if (request.Species != null)
		{
			petsQueryable = petsQueryable.Where(p => p.Species == request.Species);
		}

		if (request.SortField != null)
		{
			petsQueryable = request.SortDirection == SortDirection.Asc
				? petsQueryable.OrderBy(p => EF.Property<object>(p, request.SortField))
				: petsQueryable.OrderByDescending(p => EF.Property<object>(p, request.SortField));
		}

		var count = await petsQueryable.CountAsync();

		var page = request.Page;
		var pageSize = request.PageSize;

		var results = await petsQueryable
			.Skip((page - 1) * pageSize)
			.Take(pageSize)
			.ToListAsync();

		var pagedList = new Paged<PetListItem>
		{
			Total = count,
			Items = results
		};

		return Results.Ok(pagedList);
	}


	public async Task<IResult> GetPedigree(int petId, int generations)
	{
		var pedigreeData = await GetPedigreeData(petId, generations);

		return pedigreeData == null ? Results.NotFound() : Results.Ok(pedigreeData);
	}

	public async Task<IResult> SetAdult(int petId)
	{
		var memberId = await _userService.GetMemberId();

		if (memberId == null)
		{
			return Results.Unauthorized();
		}

		var pet =
			await _context.Pets
				.Where(p => p.Id == petId && p.OwnerId == memberId && p.Status != PetStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		if (pet == null)
		{
			return Results.BadRequest();
		}

		pet.Age = Age.Adult;

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> SetBreedingAvailability(BreedingAvailability breedingAvailability)
	{
		var memberId = await _userService.GetMemberId();

		if (memberId == null)
		{
			return Results.Unauthorized();
		}

		var pet =
			await _context.Pets
				.Where(p => p.Id == breedingAvailability.PetId && p.OwnerId == memberId && p.Status != PetStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		if (pet == null)
		{
			return Results.BadRequest();
		}

		pet.IsAvailableForBreeding = breedingAvailability.IsAvailable;

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> SetStatus(SetPetActiveStatus petActiveStatus)
	{
		var memberId = await _userService.GetMemberId();

		if (memberId == null)
		{
			return Results.Unauthorized();
		}

		var pet =
			await _context.Pets
				.Where(p => p.Id == petActiveStatus.PetId && p.OwnerId == memberId && p.Status != PetStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		if (pet == null)
		{
			return Results.BadRequest();
		}

		pet.Status = petActiveStatus.Active ? PetStatus.Active : PetStatus.Inactive;

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> SetBio(SetBioForm setBioForm)
	{
		var memberId = await _userService.GetMemberId();

		if (memberId == null)
		{
			return Results.Unauthorized();
		}

		var pet =
			await _context.Pets
				.Where(p => p.Id == setBioForm.PetId && p.OwnerId == memberId && p.Status != PetStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		if (pet == null)
		{
			return Results.BadRequest();
		}

		var validationResult = await _editEditBioFormValidator.ValidateAsync(setBioForm);

		if (!validationResult.IsValid)
		{
			return Results.ValidationProblem(validationResult.ToDictionary());
		}

		pet.CallName = setBioForm.CallName;
		pet.Bio = setBioForm.Bio;

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> UploadProfilePic(int petId, IFormFile file)
	{
		var memberId = await _userService.GetMemberId();

		if (memberId == null)
		{
			return Results.Unauthorized();
		}

		var pet =
			await _context.Pets
				.Include(p => p.ProfilePic)
				.Where(p => p.Id == petId && p.OwnerId == memberId && p.Status != PetStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		if (pet == null)
		{
			return Results.BadRequest();
		}

		// validate file size and type
		//if (!validationResult.IsValid)
		//{
		//	return Results.ValidationProblem(validationResult.ToDictionary());
		//}

		var guid = Guid.NewGuid().ToString();
		var extension = Path.GetExtension(file.FileName);
		var fileName = $"{guid}{extension}";

		var profilePicsPath = PetPicUtils.GetPicsPath(PetPicType.Profile);
		var subDirectoryPath = PetPicUtils.GetFilePathString(fileName);

		var fullPath = Path.Combine(profilePicsPath, subDirectoryPath);

		var dir = Path.GetDirectoryName(fullPath);
		Directory.CreateDirectory(dir!);

		await using (Stream fileStream = new FileStream(fullPath, FileMode.Create))
		{
			await file.CopyToAsync(fileStream);

			if (pet.ProfilePic != null)
			{
				var pathToDelete = Path.Combine(profilePicsPath,
					PetPicUtils.GetFilePathString(pet.ProfilePic.FileName));
				File.Delete(pathToDelete);

				pet.ProfilePic.FileName = fileName;
			}
			else
			{
				pet.ProfilePic = new ProfilePicEntity { FileName = fileName };
			}

			await _context.SaveChangesAsync();
		}

		return Results.Ok();
	}

	public async Task<IResult> DeleteProfilePic(int petId)
	{
		var memberId = await _userService.GetMemberId();

		if (memberId == null)
		{
			return Results.Unauthorized();
		}

		var pet =
			await _context.Pets
				.Include(p => p.ProfilePic)
				.Where(p => p.Id == petId && p.OwnerId == memberId && p.Status != PetStatus.PendingRegistration)
				.FirstOrDefaultAsync();

		if (pet == null)
		{
			return Results.BadRequest();
		}

		var profilePicsPath = PetPicUtils.GetPicsPath(PetPicType.Profile);

		if (pet.ProfilePic == null)
		{
			return Results.Ok();
		}

		var pathToDelete = Path.Combine(profilePicsPath, PetPicUtils.GetFilePathString(pet.ProfilePic.FileName));
		File.Delete(pathToDelete);

		_context.Remove(pet.ProfilePic);

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	private async Task<Pedigree?> GetPedigreeData(int petId, int generations)
	{
		var pedigreeEntries = new List<List<PedigreeEntry?>>();
		var familyTree = new List<List<PetEntity?>>();

		var ancestors = await GetAncestors(petId, generations);

		if (ancestors.Count == 0)
		{
			return null;
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

		return new Pedigree { Entries = pedigreeEntries };
	}

	private Task<List<PetEntity>> GetAncestors(int petId, int generations)
	{
		var columns = GetPetColumns();
		var pColumns = GetPetColumns("p");

		return _context.Pets.FromSqlRaw($@"
					WITH Ancestors (
					    {columns},
					    Depth
					) AS (
					    SELECT 
						    {columns},
					        0
					    FROM dbo.Pets
					    WHERE Id = {petId}

					    UNION ALL

					    SELECT 
					        {pColumns},
					        pa.Depth + 1
					    FROM 
					        dbo.Pets AS p
					        INNER JOIN Ancestors AS pa ON p.{nameof(PetEntity.Id)} = pa.{nameof(PetEntity.SireId)}

					    UNION ALL

					    SELECT 
							{pColumns},
					        pa.Depth + 1
					    FROM 
					        dbo.Pets AS p
					        INNER JOIN Ancestors AS pa ON p.{nameof(PetEntity.Id)} = pa.{nameof(PetEntity.DamId)}
					)
					SELECT * FROM Ancestors WHERE Depth <= {generations}")
			.AsNoTrackingWithIdentityResolution()
			.ToListAsync();
	}

	private static string GetPetColumns(string? alias = null)
	{
		var prefix = string.IsNullOrEmpty(alias) ? "" : $"{alias}.";

		return $@"
				{prefix}{nameof(PetEntity.Id)}, 
				{prefix}{nameof(PetEntity.ShowName)}, 
				{prefix}{nameof(PetEntity.PartialShowName)}, 
				{prefix}{nameof(PetEntity.CallName)}, 
				{prefix}{nameof(PetEntity.Bio)}, 
				{prefix}{nameof(PetEntity.PedigreeNumber)}, 
				{prefix}{nameof(PetEntity.RegistrationDate)}, 
				{prefix}{nameof(PetEntity.RegistrationPicId)}, 
				{prefix}{nameof(PetEntity.ProfilePicId)}, 
				{prefix}{nameof(PetEntity.RegistrarId)}, 
				{prefix}{nameof(PetEntity.Age)}, 
				{prefix}{nameof(PetEntity.Sex)}, 
				{prefix}{nameof(PetEntity.GameVersion)}, 
				{prefix}{nameof(PetEntity.IsAvailableForBreeding)}, 
				{prefix}{nameof(PetEntity.Status)}, 
				{prefix}{nameof(PetEntity.SireId)}, 
				{prefix}{nameof(PetEntity.DamId)}, 
				{prefix}{nameof(PetEntity.AffixId)}, 
				{prefix}{nameof(PetEntity.BreedId)}, 
				{prefix}{nameof(PetEntity.OwnerId)}, 
				{prefix}{nameof(PetEntity.BreederId)}, 
				{prefix}{nameof(PetEntity.BreedFileId)}, 
				{prefix}{nameof(PetEntity.CreatedDate)}, 
				{prefix}{nameof(PetEntity.AddedBy)}, 
				{prefix}{nameof(PetEntity.LastModifiedDate)}, 
				{prefix}{nameof(PetEntity.ModifiedBy)}";
	}
}