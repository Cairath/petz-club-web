using Hangfire;

namespace PetzBreedersClub.Jobs
{
	public static class Jobs
	{
		public static void RegisterJobs()
		{
			RecurringJob.AddOrUpdate<AgePetsJob>(x => x.Execute(), Cron.Daily);
		}
	}
}
