using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

#if DEBUG
namespace PetzBreedersClub.DTOs.User;

public class AddNotification
{
	[Required] public int UserId { get; set; }
	[Required] public required string Text { get; set; }
	[Required] public NotificationType Type { get; set; }
}
#endif