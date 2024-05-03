// static list of games
using GameStore.Api.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.JSInterop.Infrastructure;

const string GetGameEndpointName = "GetAllGames";

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
}).WithName(GetGameEndpointName);

// POST
// creates a new game
app.MapPost("/games", (Game game) =>
{
    // get the max ID of the current items and add 1
    game.Id = games.Max(game => game.Id) + 1;
    // add the new game
    games.Add(game);

    // return with a header of the object created
    return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
});

// update a game
app.MapPut("/games/{id}", (int id, Game updatedGame) =>
{
    Game? existingGame = games.Find(game => game.Id == id);

    // check if id is not found
    // return HTTP 404
    if (existingGame is null)
    {
        return Results.NotFound();
    }

    existingGame.Name = updatedGame.Name;
    existingGame.Genre = updatedGame.Genre;
    existingGame.Price = updatedGame.Price;
    existingGame.ReleaseDate = updatedGame.ReleaseDate;
    existingGame.ImageUrl = updatedGame.ImageUrl;

    return Results.NoContent();
});

// delete a game
app.MapDelete("/games/{id}", (int id) =>
{
    Game? game = games.Find(game => game.Id == id);

    if (game is not null)
    {
        // will be use to return the game deleted in the response
        Game gameDeleted = game;
        
        games.Remove(game);
        return Results.Ok(gameDeleted);
    }

    return Results.NotFound();
});

app.Run();