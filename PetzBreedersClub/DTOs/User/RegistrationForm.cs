using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database;

namespace PetzBreedersClub.DTOs.User;

	public class RegistrationForm
	{
		public required string Email { get; set; }
		public required string Password { get; set; }
		public required string MemberName { get; set; }
	}

public class RegistrationFormValidator : AbstractValidator<RegistrationForm>
{
	public RegistrationFormValidator(Context context)
	{
		RuleFor(x => x.Email)
			.NotEmpty()
			.EmailAddress()
			.Matches(
				@"^(([^<>()\[\]\\.,;:\s@']+(.[^<>()\[\]\\.,;:\s@']+)*)|('.+'))@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}])|(([a-zA-Z-0-9]+.)+[a-zA-Z]{2,}))$")
			.WithMessage("Invalid email address")
			.MustAsync(async (email, ct) =>
				await context.Users.AllAsync(u => u.Email != email, ct))
			.WithMessage("This email address is already in use");
		
		RuleFor(x => x.Password)
			.NotEmpty()
			.MinimumLength(8);

		RuleFor(x=>x.MemberName)
			.NotEmpty()
			.MinimumLength(3)
			.MaximumLength(30)
			.Matches("^[A-Za-zÀ-ȕ]([ ]?[A-Za-zÀ-ȕ'])*[A-Za-zÀ-ȕ']*$")
			.WithMessage("Display name can contain only letters, spaces and apostrophes, cannot start or end with a space and there can be no consecutive spaces")
			.MustAsync(async (email, ct) =>
				await context.Users.Include(u=>u.Member).AllAsync(u => u.Member.Name != email, ct))
				.WithMessage("This name is already in use");
	}
}