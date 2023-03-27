using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models.Seeds;

public static class BreedsDogsGroup1
{
	public static void Seed(ModelBuilder modelBuilder)
	{
		var breedId = 0;
		var breeds = new List<BreedEntity>();
		var varieties = new List<BreedVarietyEntity>();

		//todo: static IDs when the breed lists are finalized
		breeds.AddRange(new List<BreedEntity>
		{
			new()
			{
				Id = ++breedId,
				Name = "Australian Kelpie",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Belgian Shepherd Dog Groenendael",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Belgian Shepherd Dog Laekenois",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Belgian Shepherd Dog Malinois",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Belgian Shepherd Dog Tervueren",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Schipperke",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Croatian Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Briard",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Picardy Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Pyrenean Sheepdog - Long haired",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Pyrenean Sheepdog - Smooth faced",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "German Shepherd Dog - Short haired",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "German Shepherd Dog - Longhair",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Bearded Collie",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Border Collie",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Rough Collie",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Smooth Collie",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Old English Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Shetland Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Komondor",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Kuvasz",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Mudi",
				Group = 1,
				Section = 1
			}
		});

		varieties.AddRange(new List<BreedVarietyEntity>()
		{
			new()
			{
				BreedId = breedId,
				Name = "fawn" //FCI: all judged together
			},
			new()
			{
				BreedId = breedId,
				Name = "black"
			},
			new()
			{
				BreedId = breedId,
				Name = "blue merle"
			},
			new()
			{
				BreedId = breedId,
				Name = "ash colored"
			},
			new()
			{
				BreedId = breedId,
				Name = "brown"
			},
			new()
			{
				BreedId = breedId,
				Name = "white"
			}
		});

		breeds.Add(
		new()
			{
				Id = ++breedId,
			Name = "Puli",
				Group = 1,
				Section = 1
			});

		varieties.AddRange(new List<BreedVarietyEntity>()
			{
				new()
				{
					BreedId = breedId,
					Name = "pearl-white" //FCI: judged separately
				},
				new()
				{
					BreedId = breedId,
					Name = "black" //FCI: judged together with all the colors below
				},
				new()
				{
					BreedId = breedId,
					Name = "black shaded with rust-red or gray"
				},
				new()
				{
					BreedId = breedId,
					Name = "fawn"
				},
				new()
				{
					BreedId = breedId,
					Name = "gray in any shade"
				}
			}
		);

		breeds.AddRange(new List<BreedEntity>{
			new()
			{
				Id = ++breedId,
				Name = "Pumi",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Bergamasco Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Maremma Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Polish Lowland Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Tatra Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Portuguese Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Romanian Carpathian Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Romanian Mioritic Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "South Russian Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Czechoslovakian Wolfdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Slovakian Chuvach",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Catalan Sheepdog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Majorca Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "White Swiss Shepherd Dog",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Dutch Schapendoes",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Dutch Shepherd Dog (Short-haired)",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Dutch Shepherd Dog (Long Haired)",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Dutch Shepherd Dog (Rough haired)",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Saarloos Wolfhond",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Australian Shepherd",
				Group = 1,
				Section = 1
			},
			new()
			{
				Id = ++breedId,
				Name = "Australian Cattle Dog",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Bouvier Des Ardennes",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Bouvier Des Flandres",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Welsh Corgi Cardigan",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Welsh Corgi Pembroke",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Australian Stumpy Tailed Cattle Dog",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Lancashire Heeler",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Miniature American Shepherd",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Catahoula Leopard Dog",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "Bohemian Shepherd Dog",
				Group = 1,
				Section = 2
			},
			new()
			{
				Id = ++breedId,
				Name = "English Shepherd Dog",
				Group = 1,
				Section = 2
			}
		});

		var date = new DateTime(2023, 3, 11);

		foreach (var b in breeds)
		{
			b.Species = Species.Dogz;
			b.AddedBy = "system";
			b.CreatedDate = date;
		}

		var varietyId = 0;
		foreach (var v in varieties)
		{
			v.Id = ++varietyId;
			v.AddedBy = "system";
			v.CreatedDate = date;
		}

		modelBuilder.Entity<BreedEntity>().HasData(breeds);
		modelBuilder.Entity<BreedVarietyEntity>().HasData(varieties);
	}
}
