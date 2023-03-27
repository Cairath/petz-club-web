namespace PetzBreedersClub.Services;

public static class PetPicUtils
{
	public static string GetFilePathString(string fileName)
	{
		var two = fileName[0..2];
		var four = fileName[0..4];

		var path = Path.Combine(two, four, fileName);

		return path;
	}

	public static string GetPicsPath(PetPicType type)
	{
		var directory = GetDirectoryString(type);
		var location = Path.Combine("C:", "Desktop", "pbc", directory);

		return location;
	}

	private static string GetDirectoryString(PetPicType type)
	{
		return type switch
		{
			PetPicType.Registration => "registration",
			PetPicType.Profile => "profile",
			_ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
		};
	}
}

public enum PetPicType
{
	Registration,
	Profile
}

