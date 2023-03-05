using Microsoft.AspNetCore.Identity;
using PetzBreedersClub.Database;
using PetzBreedersClub.Database.Models;
using PetzBreedersClub.DTOs.User;

namespace PetzBreedersClub.Services.Auth;

public interface IUserService
{
	string? GetUserId();
	Task<IResult> RegisterNewUser(RegistrationForm registrationForm);
	Task<IResult> SignIn(UserSignIn userSignIn);
	Task<IResult> SignOut();
	Task<UserEntity?> GetUser();
	Task<ClientUserInfo?> GetClientUserInfo();
}

public class UserService : IUserService
{
	private readonly Context _context;
	private readonly RegistrationFormValidator _registrationFormValidator;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly UserManager<UserEntity> _userManager;
	private readonly SignInManager<UserEntity> _signInManager;


	public UserService(Context context,
		RegistrationFormValidator registrationFormValidator, 
		UserManager<UserEntity> userManager,
		SignInManager<UserEntity> signInManager,
		IHttpContextAccessor httpContextAccessor)
	{
		_context = context;
		_registrationFormValidator = registrationFormValidator;
		_httpContextAccessor = httpContextAccessor;
		_userManager = userManager;
		_signInManager = signInManager;
		
	}

	public string? GetUserId()
	{
		var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
		return claimsPrincipal != null ?  _userManager.GetUserId(claimsPrincipal) : null;
	}

	public async Task<UserEntity?> GetUser()
	{
		var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
		return claimsPrincipal != null ? await _userManager.GetUserAsync(claimsPrincipal) : null;
	}

	public async Task<ClientUserInfo?> GetClientUserInfo()
	{
		var claimsPrincipal = _httpContextAccessor.HttpContext?.User;
		var user = claimsPrincipal != null ? await _userManager.GetUserAsync(claimsPrincipal) : null;

		if (user == null)
		{
			return null;
		}

		await _context.Entry(user).Reference(u => u.Member).LoadAsync();

		return new ClientUserInfo { Id = user.Id, Email = user.Email, DisplayName = user.Member.Name};
	}

	public async Task<IResult> RegisterNewUser(RegistrationForm registrationForm)
	{
		var validationResult = await _registrationFormValidator.ValidateAsync(registrationForm);

		if (!validationResult.IsValid)
		{
			return Results.ValidationProblem(validationResult.ToDictionary());
		}
		
		var userEntity = new UserEntity
		{
			UserName = registrationForm.Email,
			Email = registrationForm.Email,
			Member = new MemberEntity
			{
				Name = registrationForm.MemberName
			}
		};

		await _userManager.CreateAsync(userEntity, registrationForm.Password);

		return Results.Ok();
	}

	public async Task<IResult> SignIn(UserSignIn userSignIn)
	{
		var user = await _userManager.FindByEmailAsync(userSignIn.Email);

		if (user == null)
		{
			return Results.Unauthorized();
		}

		var signInResult =  await _signInManager.PasswordSignInAsync(userSignIn.Email, userSignIn.Password, userSignIn.RememberMe, false);

		if (!signInResult.Succeeded)
		{
			return Results.Unauthorized();
		}

		await _context.Entry(user).Reference(u => u.Member).LoadAsync();

		return TypedResults.Ok(new ClientUserInfo { Id = user.Id, Email = user.Email, DisplayName = user.Member.Name });
	}

	public async Task<IResult> SignOut()
	{
		await _signInManager.SignOutAsync();
		return Results.Ok();
	}
}