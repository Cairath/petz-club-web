using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database;
using PetzBreedersClub.DTOs.Auth;
using PetzBreedersClub.Endpoints;
using PetzBreedersClub.Services.Auth;

namespace PetzBreedersClub;

public class Program
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

		builder.Services.AddControllers();
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

		builder.Services.AddValidatorsFromAssembly(typeof(Program).Assembly);

		builder.Services.AddHttpContextAccessor();
		builder.Services.AddScoped<IUserService, UserService>();
		builder.Services.AddSingleton<IPasswordHasher<User>, PasswordHasher<User>>();

		var app = builder.Build();
		
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		};

		app.UseCors(devCorsPolicy);

		app.UseHttpsRedirection();
		app.UseAuthorization();

		app.MapPetsEndpoints();
		app.MapUserEndpoints();

		app.Run();
	}
}
