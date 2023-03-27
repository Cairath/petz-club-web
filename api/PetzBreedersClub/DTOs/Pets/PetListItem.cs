using PetzBreedersClub.Database.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetzBreedersClub.DTOs.Pets;

public class PetListItem
{
	[Required] public int Id { get; set; }
	[Required] public required string ShowName { get; set; }
	[Required] public required string PedigreeNumber { get; set; }
	[Required] public Age Age { get; set; }
	[Required] public Sex Sex { get; set; }
	[Required] public GameVersion GameVersion { get; set; }
	[Required] public Species Species { get; set; }
	[Required] public PetStatus Status { get; set; }
	[Required] public int BreedId { get; set; }
	[Required] public required string BreedName { get; set; }
	[Required] public int OwnerId { get; set; }
	[Required] public required string OwnerName { get; set; }
	[Required] public int AffixId { get; set; }
	[Required] public required string AffixName { get; set; }
}

public interface ISorted
{
	public string? SortField { get; set; }
	public SortDirection? SortDirection { get; set; }
}

public interface IPaged
{
	public int PageSize { get; set; }
	public int Page { get; set; }
}

public interface IFiltered<T>
{
	public T Filters { get; set; }
}

public enum SortDirection
{
	Asc,
	Desc
}


public class PetListRequest : IPaged, ISorted
{
	public int? OwnerId { get; set; }
	public string? OwnerName { get; set; }
	public string? ShowName { get; set; }
	public int? AffixId { get; set; }
	public string? AffixName { get; set; }
	public string? PedigreeNumber { get; set; }
	public int? BreedId { get; set; }
	public string? BreedName { get; set; }
	public Sex? Sex { get; set; }
	public Age? Age { get; set; }
	public Species? Species { get; set; }
	public PetStatus? Status { get; set; }
	public GameVersion? GameVersion { get; set; }
	
	public int PageSize { get; set; }
	public int Page { get; set; }
	public string? SortField { get; set; }
	public SortDirection? SortDirection { get; set; }
}

public class Paged<T>
{
	public int Total { get; set; }
	public List<T> Items { get; set; } = new();
}
