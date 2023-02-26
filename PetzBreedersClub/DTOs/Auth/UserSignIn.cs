namespace PetzBreedersClub.DTOs.Auth;

public class UserSignIn
{
	public required string Email { get; set; }
	public required string Password { get; set; }
}