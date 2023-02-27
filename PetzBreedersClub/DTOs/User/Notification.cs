using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.User;

public class Notification
{
	public DateTime Date { get; set; }
	public required string Text { get; set; }
	public NotificationType Type { get; set; }
	public bool Read { get; set; }
}