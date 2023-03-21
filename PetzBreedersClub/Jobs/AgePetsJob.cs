using Hangfire;
using PetzBreedersClub.Database;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Jobs;

public class AgePetsJob : JobActivator
{
	public const string JobName = "Age Pets";

	private readonly IServiceProvider _serviceProvider;

	public AgePetsJob(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider;
	}

	[JobDisplayName(JobName)]
	public async Task Execute()
	{
		using var scope = _serviceProvider.CreateScope();
		await using var context = scope.ServiceProvider.GetRequiredService<Context>();

		var pets = context.Pets.Where(p => p.RegistrationDate < DateTime.UtcNow.AddMonths(-6) && p.Age == Age.Junior);

		foreach (var pet in pets)
		{
			pet.Age = Age.Adult;
		}

		await context.SaveChangesAsync();
	}
}