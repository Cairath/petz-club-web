using Newtonsoft.Json;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.Services.Notifications;

public static class NotificationGenerator
{
	public static SystemNotificationEntity PetRegistrationApproved(int petId, string showName, int userId)
	{
		return new SystemNotificationEntity
		{
			Content = NotificationContent.PetRegistrationApproved,
			Type = NotificationType.Success,
			Text = $"Pet {showName} has been registered.",
			UserId = userId,
			Params = JsonConvert.SerializeObject(new { petId = petId })
		};
	}

	public static SystemNotificationEntity AffixRegistrationApproved(int affixId, string name, int userId)
	{
		return new SystemNotificationEntity
		{
			Content = NotificationContent.AffixRegistrationApproved,
			Type = NotificationType.Success,
			Text = $"Affix registration for \"{name}\" has been approved.",
			UserId = userId,
			Params = JsonConvert.SerializeObject(new { affixId })
		};
	}

	public static SystemNotificationEntity AffixRegistratonRejected(string name, string reason, int userId)
	{
		return new SystemNotificationEntity
		{
			Content = NotificationContent.AffixRegistrationApproved,
			Type = NotificationType.Error,
			Text = $"Affix registration for \"{name}\" has been rejected. Reason: {reason}",
			UserId = userId
		};
	}
}