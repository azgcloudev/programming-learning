namespace GameStore.Api.Entities;

public class Game
{
    public int Id { get; set; }
    // required = when initializing an object this property have to be used
    public required string Name { get; set; } = string.Empty;
    public required string Genre { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
    public required string ImageUrl { get; set; }
}
