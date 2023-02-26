using Microsoft.AspNetCore.Mvc;
using PetzBreedersClub.DTOs.Auth;
using PetzBreedersClub.Services.Auth;

namespace PetzBreedersClub.Endpoints;

public static class UserEndpoints
{
	public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
	{
		var group = routes.MapGroup("/api/users").WithTags("Users");

		group.MapPost("/register", async (RegistrationForm registrationForm, IUserService userService) =>
			{
				return await userService.RegisterNewUser(registrationForm);
			})
			.WithName("RegisterUser")
			.WithOpenApi();

		group.MapPost("/sign-in", async (UserSignIn user, IUserService userService) =>
			{
				return await userService.SignIn(user);
			})
			.WithName("SignIn")
			.Produces<SignedInUserInfo>()
			.WithOpenApi();

		group.MapPost("/sign-out", async (IUserService userService) =>
			{
				var a = userService.GetUserId();
				 return await userService.SignOut();
			})
			.WithName("SignOut")
			.WithOpenApi();

		group.MapPost("/authenticate", ([FromBody]int userId, HttpContext httpContext, IUserService userService) =>
			{
				return httpContext.User.Identity?.IsAuthenticated ?? userService.GetUserId() == userId.ToString();
			})
			.WithName("Authenticate")
			.Produces<bool>()
			.WithOpenApi();
	}
}