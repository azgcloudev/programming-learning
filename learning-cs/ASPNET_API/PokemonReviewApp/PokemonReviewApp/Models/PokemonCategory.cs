namespace PokemonReviewApp.Models;

// this class represents a table with a many to many relationship
public class PokemonCategory
{
    public int PokemonId { get; set; }
    public int CategoryId { get; set; }
    public Pokemon Pokemon { get; set; }
    public Category Category { get; set; }
}