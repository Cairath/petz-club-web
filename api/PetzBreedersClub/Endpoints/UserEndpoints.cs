using Microsoft.AspNetCore.Mvc;
using PetzBreedersClub.DTOs.Notifications;
using PetzBreedersClub.DTOs.User;
using PetzBreedersClub.Services;
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
			.Produces<ClientUserInfo>()
			.WithOpenApi();

		group.MapPost("/sign-out", async (IUserService userService) =>
			{
				return await userService.SignOut();
			})
			.WithName("SignOut")
			.WithOpenApi();

		group.MapPost("/authenticate", async (IUserService userService) =>
			{
				return await userService.GetClientUserInfo();
			})
			.WithName("Authenticate")
			.Produces<ClientUserInfo?>()
			.WithOpenApi();

		group.MapGet("/notifications", async (INotificationService notificationService) =>
			{
				return await notificationService.GetUserNotifications();
			})
			.WithName("GetUserNotifications")
			.Produces<List<Notification>>()
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/notifications/delete", async ([FromBody] int notificationId, INotificationService notificationService) =>
			{
				return await notificationService.DeleteNotification(notificationId);
			})
			.WithName("DeleteNotification")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/notifications/mark-all-read", async (INotificationService notificationService) =>
			{
				return await notificationService.MarkNotificationsAsRead();
			})
			.WithName("MarkAllNotificationsAsRead")
			.RequireAuthorization()
			.WithOpenApi();

		group.MapPost("/notifications/mark-read", async ([FromBody] int notificationId, INotificationService notificationService) =>
			{
				return await notificationService.MarkNotificationsAsRead(notificationId);
			})
			.WithName("MarkNotificationAsRead")
			.RequireAuthorization()
			.WithOpenApi();

#if DEBUG
		group.MapPost("/notifications/add", async (AddNotification form, INotificationService notificationService) =>
			{
				await notificationService.AddNotification(new List<int>() { form.UserId }, text: form.Text, form.Type);
			})
			.WithName("DEVAddNotification")
			.WithOpenApi();
#endif
	}
}