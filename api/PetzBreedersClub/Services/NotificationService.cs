using PetzBreedersClub.Database;
using PetzBreedersClub.Services.Auth;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database.Models.Enums;
using PetzBreedersClub.DTOs.Notifications;

namespace PetzBreedersClub.Services;

public interface INotificationService
{
	Task AddNotification(List<int> userIds, string text, NotificationType type);
	Task<IResult> GetUserNotifications();
	Task<IResult> MarkNotificationsAsRead(int? notificationId);
	Task<IResult> MarkNotificationsAsRead();
	Task<IResult> DeleteNotification(int notificationId);
}

public class NotificationService : INotificationService
{
	private readonly Context _context;
	private readonly IUserService _userService;

	public NotificationService(Context context, IUserService userService)
	{
		_context = context;
		_userService = userService;
	}

	public async Task AddNotification(List<int> userIds, string text, NotificationType type)
	{
		var notifications = new List<SystemNotificationEntity>();

		//todo: validate users exist

		foreach (var userId in userIds)
		{
			notifications.Add(new SystemNotificationEntity
			{
				Read = false,
				Text = text,
				Type = type,
				UserId = userId
			});
		}

		_context.SystemNotifications.AddRange(notifications);
		await _context.SaveChangesAsync();
	}

	public async Task<IResult> GetUserNotifications()
	{
		var userId = int.Parse(_userService.GetUserId()!);

		var notifications = await _context.SystemNotifications.Where(sn => sn.UserId == userId)
			.Select(sn => new Notification
		{
			Id = sn.Id,
			Date = sn.CreatedDate,
			Read = sn.Read,
			Text = sn.Text,
			Type = sn.Type
		}).ToListAsync();

		return Results.Ok(notifications);
	}

	public async Task<IResult> MarkNotificationsAsRead(int? notificationId)
	{
		if (notificationId == null)
		{
			return await MarkNotificationsAsRead();
		}

		var userId = int.Parse(_userService.GetUserId()!);

		var notification =
			await _context.SystemNotifications.FirstOrDefaultAsync(sn => sn.UserId == userId && sn.Id == notificationId);

		if (notification == null)
		{
			return Results.Unauthorized();
		}

		notification.Read = true;
		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> MarkNotificationsAsRead()
	{
		var userId = int.Parse(_userService.GetUserId()!);

		var notifications =
			await _context.SystemNotifications.Where(sn => sn.UserId == userId).ToListAsync();

		foreach (var notification in notifications)
		{
			notification.Read = true;
		}

		await _context.SaveChangesAsync();

		return Results.Ok();
	}

	public async Task<IResult> DeleteNotification(int notificationId)
	{
		var userId = int.Parse(_userService.GetUserId()!);
		var notification =
			await _context.SystemNotifications.FirstOrDefaultAsync(sn => sn.UserId == userId && sn.Id == notificationId);

		if (notification == null)
		{
			return Results.Unauthorized();
		}

		_context.SystemNotifications.Remove(notification);
		await _context.SaveChangesAsync();

		return Results.Ok();
	}

}