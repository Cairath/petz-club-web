using PetzBreedersClub.Database.Models.Enums;

#if DEBUG
namespace PetzBreedersClub.DTOs.User;

public class AddNotification
{
	public int UserId { get; set; }
	public string Text { get; set; }
	public NotificationType Type { get; set; }
}
#endif