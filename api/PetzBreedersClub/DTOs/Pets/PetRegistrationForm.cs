using System.ComponentModel.DataAnnotations;
using FluentValidation;
using PetzBreedersClub.Database;
using PetzBreedersClub.Database.Models.Enums;

namespace PetzBreedersClub.DTOs.Pets
{
	public enum RegistrationType
	{
		PurebredShow,
		PurebredPet,
		Mixed
	}

	public class PetRegistrationForm
	{
		[Required] public Species Species { get; set; }
		[Required] public RegistrationType RegistrationType { get; set; }
		[Required] public int BreedId { get; set; } 
		public int VarietyId { get; set; }
		[Required] public int AffixId { get; set; }
		[Required] public required string Name { get; set; }
		[Required] public required string CallName { get; set; }
	}

	public class PetRegistrationFormValidator : AbstractValidator<PetRegistrationForm>
	{
		public PetRegistrationFormValidator(Context context)
		{
		}
	}
}
