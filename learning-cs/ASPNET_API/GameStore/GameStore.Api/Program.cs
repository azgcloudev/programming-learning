// static list of games
using GameStore.Api.Entities;

List<Game> games = new() {
    new Game()
    {
        Id = 1,
        Name = "Street fighter II",
        Genre = "Fighting",
        Price = 19.99M,
        ReleaseDate = new DateTime(1999,2,1),
        ImageUrl = "http://placehold.co/100"
    },
    new Game()
    {
        Id = 2,
        Name = "Final Fantasy XIV",
        Genre = "Roleplaying",
        Price = 59.99M,
        ReleaseDate = new DateTime(2010,9,30),
        ImageUrl = "http://placehold.co/100"
    },
    new Game()
    {
        Id = 3,
        Name = "FIFA 23",
        Genre = "Sports",
        Price = 69.99M,
        ReleaseDate = new DateTime(2022,9,27),
        ImageUrl = "http://placehold.co/100"
    }
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/games", () => games);

// retrive a game by the ID number
app.MapGet("/games/{id}", (int id) =>
{
    Game? game = games.Find(game => game.Id == id);

    // check if id is not found
    // return HTTP 404
    if (game is null)
    {
        return Results.NotFound();
    }

    // returnd HTTP 202 when the game is found
    return Results.Ok(game);
});

app.Run();