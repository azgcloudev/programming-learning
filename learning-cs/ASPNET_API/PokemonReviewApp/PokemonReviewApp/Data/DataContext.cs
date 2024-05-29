using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Data;

public class DataContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<PokemonOwner> PokemonOwners { get; set; }
    public DbSet<PokemonCategory> PokemonCategories { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Reviewer> Reviewers { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // for many to many tables
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // this tells EF to join the two IDs: PokemonId with CategoryId
        modelBuilder.Entity<PokemonCategory>().HasKey(pc => new { pc.PokemonId, pc.CategoryId });
        modelBuilder.Entity<PokemonCategory>()
            .HasOne(p => p.Pokemon)
            .WithMany(pc => pc.PokemonCategories)
            .HasForeignKey(p => p.PokemonId);
    }
}