using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace PetzBreedersClub.DTOs.Pets
{
	public class SetBioForm
	{
		[Required] public int PetId { get; set; } 
		[Required] public required string CallName { get; set; } 
		public string? Bio { get; set; }
	}

	public class EditBioFormValidator : AbstractValidator<SetBioForm>
	{
		public EditBioFormValidator()
		{
			RuleFor(x => x.PetId)
				.NotNull();

			RuleFor(x => x.CallName)
				.NotEmpty()
				.MinimumLength(2)
				.MaximumLength(25)
				.Matches("^[A-Za-zÀ-ȕ]([ ]?[A-Za-zÀ-ȕ'])*[A-Za-zÀ-ȕ']*$")
				.WithMessage("Call name can contain only letters, spaces and apostrophes");

			RuleFor(x => x.Bio)
				.MaximumLength(255);
		}
	}
}
