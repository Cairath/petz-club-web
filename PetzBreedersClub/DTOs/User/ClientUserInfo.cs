using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.User
{
	public class ClientUserInfo
	{
		[Required] public int Id { get; set; }
		[Required] public required string Email { get; set; }
		[Required] public required string DisplayName { get; set; }
		[Required] public int MemberId { get; set; }
	}
}
