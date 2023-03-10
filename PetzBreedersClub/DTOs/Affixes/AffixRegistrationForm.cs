using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PetzBreedersClub.Database;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Affixes
{
	public class AffixRegistrationForm
	{
		[Required] public required string Name { get; set; }
		[Required] public required AffixSyntax Syntax { get; set; }
	}

	public class AffixRegistrationFormValidator : AbstractValidator<AffixRegistrationForm>
	{
		public AffixRegistrationFormValidator(Context context)
		{
			RuleFor(x => x.Name)
				.NotEmpty()
				.MinimumLength(3)
				.MaximumLength(35)
				.Matches("^[A-Za-zÀ-ȕ]([ ]?[A-Za-zÀ-ȕ])*[A-Za-zÀ-ȕ]*$")
				.WithMessage("Affix name can contain only letters")
				.MustAsync(async (name, ct) => await context.Affixes.AllAsync(u => u.Name != name, ct))
				.WithMessage("An affix with this name is already registered")
				.MustAsync(async (name, ct) =>
					await context.AffixesPendingRegistration.AllAsync(u => u.Name != name, ct))
				.WithMessage("An affix with this name is already pending registration")
				.CustomAsync(async (x, ctx, ct) =>
				{
					var userId = int.Parse(ctx.RootContextData["UserId"] as string ??
										   throw new InvalidOperationException());

					var registeredCount = await context.AffixesPendingRegistration
						.Where(ap => ap.OwnerId == userId).CountAsync(ct);

					var pendingCount = await context.Affixes
						.Where(ap => ap.OwnerId == userId).CountAsync(ct);

					if (registeredCount + pendingCount >= 50)
					{
						ctx.AddFailure("Maximum number of affixes (registered + pending) is 50");
					}
				});
		}
	}
}
