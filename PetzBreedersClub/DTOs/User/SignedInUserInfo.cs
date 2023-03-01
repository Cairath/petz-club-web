using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.User
{
	public class SignedInUserInfo
	{
		[Required] public int Id { get; set; }
		[Required] public required string Email { get; set; }
	}
}
