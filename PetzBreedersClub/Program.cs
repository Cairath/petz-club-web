using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database;
using PetzBreedersClub.Endpoints;
using PetzBreedersClub.Services;
using PetzBreedersClub.Services.Auth;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.Extensions.Caching.Memory;
using PetzBreedersClub.DTOs.User;
using MvcJsonOptions = Microsoft.AspNetCore.Mvc.JsonOptions;

namespace PetzBreedersClub;

public static class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddDbContext<Context>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("PetzBreedersClub")
							 ?? throw new InvalidOperationException("Connection string 'PetzBreedersClub' not found.")));

		var devCorsPolicy = "Development";
		builder.Services.AddCors(options =>
		{
			options.AddPolicy(name: devCorsPolicy,
				policy =>
				{
					policy.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().AllowCredentials();
				});
		});

		builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
			.AddCookie(options =>
			{
				options.Cookie.Name = "PBC.Identity";
				options.Cookie.IsEssential = true;
				options.SlidingExpiration = true;
				options.Cookie.Domain = "localhost";
				options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
				options.Cookie.SameSite = SameSiteMode.None; //TODO CHANGE LATER
				options.ExpireTimeSpan = TimeSpan.FromMinutes(15);
			});
		
		builder.Services.AddAuthentication();
		builder.Services.AddAuthorization();

		builder.Services.AddEndpointsApiExplorer();

		builder.Services.Configure<JsonOptions>(options =>
		{
			options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
			options.SerializerOptions.WriteIndented = true;
		});

		//workaround for swagger issue: https://github.com/domaindrivendev/Swashbuckle.AspNetCore/issues/2293#issuecomment-991870685
		builder.Services.Configure<MvcJsonOptions>(o =>
		{
			o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
			o.JsonSerializerOptions.WriteIndented = true;
		});

		builder.Services.AddSwaggerGen();

		builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

		builder.Services.AddHttpContextAccessor();

		builder.Services.AddServices();

		builder.Services.AddSingleton<IMemoryCache, MemoryCache>();
		builder.Services.AddSingleton<IPasswordHasher<User>, PasswordHasher<User>>();

		var app = builder.Build();
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseCors(devCorsPolicy);

		app.UseHttpsRedirection();
		app.UseAuthorization();

		app.MapEndpoints();

		app.Run();
	}

	private static void AddServices(this IServiceCollection services)
	{
		services.AddScoped<IUserService, UserService>();
		services.AddScoped<INotificationService, NotificationService>();
		services.AddScoped<IBreedService, BreedService>();
		services.AddScoped<IAffixService, AffixService>();
		services.AddScoped<IStaffService, StaffService>();
	}

	private static void MapEndpoints(this WebApplication app)
	{
		app.MapPetsEndpoints();
		app.MapUserEndpoints();
		app.MapBreedsEndpoints();
		app.MapAffixEndpoints();
		app.MapStaffEndpoints();
	}
}


