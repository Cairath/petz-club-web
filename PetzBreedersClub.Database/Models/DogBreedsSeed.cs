using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Database.Models;

public class DogBreedsSeed
{
	private static readonly List<BreedEntity> Breeds = new()
	{
		new()
		{
			Name = "Australian Kelpie",
			Group = 1,
			Section = 1
		},
		new()
		{
			Name = "Belgian Shepherd Dog (Groenendael)",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Belgian Shepherd Dog (Laekenois)",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Belgian Shepherd Dog (Malinois)",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Belgian Shepherd Dog (Tervueren)",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Shipperke",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Croatian Shepherd Dog",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Briard",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Pyrenean Sheepdog Longhaired",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Picardy Sheepdog",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "Pyrenean Sheepdog Smooth Faced",
			Group = 1,
			Section = 1,
		},
		new()
		{
			Name = "German Shepherd Dog (Double Coat)",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "German Shepherd Dog (Long and Harsh Outer Coat)",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Bearded Collie",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Border Collie",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Collie (Rough)",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Collie (Smooth)",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Shetland Sheepdog",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Komondor",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Kuvasz",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Mudi",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Puli (pearl-white)",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Puli (other colors)",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Pumi",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Bergamasco Shepherd Dog",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Maremma and the Abruzzes Sheepdog",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Polish Lowland Sheepdog",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Tatra Shepherd Dog",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Portuguese Sheepdog",
			Group = 1,
			Section = 1,
		},
		new() {
			Name = "Romanian Carpathian Shepherd Dog",
			Group = 1,
			Section = 1,
		}
	};

	public static void Seed(ModelBuilder modelBuilder)
	{
		var id = 1;
		foreach (var b in Breeds)
		{
			b.Species = Species.Dogz;
			b.Id = id++;
			b.AddedBy = "system";
			b.CreatedDate = DateTime.UtcNow;
		}

		modelBuilder.Entity<BreedEntity>().HasData(Breeds);
	}
}
