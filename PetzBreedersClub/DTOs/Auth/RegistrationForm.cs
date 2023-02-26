﻿using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database;

namespace PetzBreedersClub.DTOs.Auth;

	public class RegistrationForm
	{
		public required string Email { get; set; }
		public required string Password { get; set; }
		public required string MemberName { get; set; }
	}

public class RegistrationFormValidator : AbstractValidator<RegistrationForm>
{
	private readonly Context _context;

	public RegistrationFormValidator(Context context)
	{
		_context = context;

		RuleFor(x => x.Email).NotEmpty().EmailAddress()
			.MustAsync(async (email, ct) =>
			await context.Users.AllAsync(u => u.Email != email, ct));
		RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
		RuleFor(x=>x.MemberName).NotEmpty().MinimumLength(3);
	}
}
