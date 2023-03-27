using FluentValidation;
using MimeDetective;

namespace PetzBreedersClub.Services;

public class PetPicFileValidator : AbstractValidator<IFormFile>
{
	private readonly string[] _mimeTypes =
	{
		"image/bmp",
		"image/png"
	};

	public PetPicFileValidator()
	{
		RuleFor(x => x.Length)
			.LessThanOrEqualTo(1024 * 1024)
			.WithMessage("File cannot be bigger than 1 MB");

		RuleFor(x => "Type")
			.Custom((_, ctx) =>
			{
				var inspector = new ContentInspectorBuilder()
				{
					Definitions = MimeDetective.Definitions.Default.All()
				}.Build();
				
				var stream = ctx.InstanceToValidate.OpenReadStream();
				var fileType = inspector.Inspect(stream);

				if (!_mimeTypes.Contains(fileType.ElementAt(0).Definition.File.MimeType))
				{
					ctx.AddFailure("Only .png and .bmp files allowed");
				}
			});
	}
}