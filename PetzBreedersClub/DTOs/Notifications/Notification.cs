using System.ComponentModel.DataAnnotations;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Notifications;

public class Notification
{
    [Required] public int Id { get; set; }
    [Required] public DateTime Date { get; set; }

    [Required] public required string Text { get; set; }

    [Required] public NotificationType Type { get; set; }

    [Required] public bool Read { get; set; }
}