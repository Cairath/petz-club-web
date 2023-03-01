using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using PetzBreedersClub.Database;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.DTOs.User;

namespace PetzBreedersClub.Services.Auth;

public interface IUserService
{
	string? GetUserId();
	Task<IResult> RegisterNewUser(RegistrationForm registrationForm);
	Task<IResult> SignIn(UserSignIn user);
	Task<IResult> SignOut();
}

public class UserService : IUserService
{
	private readonly Context _context;
	private readonly RegistrationFormValidator _registrationFormValidator;
	private readonly IPasswordHasher<User> _passwordHasher;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public UserService(Context context, RegistrationFormValidator registrationFormValidator, IPasswordHasher<User> passwordHasher,
		IHttpContextAccessor httpContextAccessor)
	{
		_context = context;
		_registrationFormValidator = registrationFormValidator;
		_passwordHasher = passwordHasher;
		_httpContextAccessor = httpContextAccessor;
	}

	public string? GetUserId()
	{
		return _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
	}

	public async Task<IResult> RegisterNewUser(RegistrationForm registrationForm)
	{
		var validationResult = await _registrationFormValidator.ValidateAsync(registrationForm);

		if (!validationResult.IsValid)
		{
			return Results.ValidationProblem(validationResult.ToDictionary());
		}

		var user = new User { Email = registrationForm.Email };

		var userEntity = new UserEntity
		{
			Email = registrationForm.Email,
			PasswordHash = _passwordHasher.HashPassword(user, registrationForm.Password),
			Member = new MemberEntity
			{
				Name = registrationForm.MemberName
			}
		};

		userEntity.Member.User = userEntity;

		_context.Users.Add(userEntity);

		await _context.SaveChangesAsync();

		await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Convert(user));

		return Results.Ok(user);
	}

	public async Task<IResult> SignIn(UserSignIn user)
	{
		//todo: validate

		var userEntity = _context.Users.FirstOrDefault(u => u.Email == user.Email);
		if (userEntity == null)
		{
			return Results.Unauthorized(); //?
		}

		var userIdentity = new User { Id = userEntity.Id, Email = user.Email };


		var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(userIdentity, userEntity.PasswordHash, user.Password);
		if (passwordVerificationResult != PasswordVerificationResult.Success)
		{
			return Results.Unauthorized(); //?
		}

		await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, Convert(userIdentity));

		return TypedResults.Ok(new SignedInUserInfo { Id = userIdentity.Id, Email = userIdentity.Email });
	}

	public async Task<IResult> SignOut()
	{
		await _httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); //TODO configure default auth scheme
		return Results.Ok();
	}

	public static ClaimsPrincipal Convert(User user)
	{
		var claims = new List<Claim>
		{
			new(ClaimTypes.NameIdentifier, user.Id.ToString())
		};

		var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
		return new ClaimsPrincipal(identity);
	}
}