using System;
using System.Linq;
using LinqUsingEnumerable;

QueryStringWithOperators();

Console.WriteLine();
QueryStringsWithEnumerableAndLambdas();

Console.WriteLine();
QueryStringsWithAnonymousMethods();

Console.WriteLine();
VeryComplexQueryExpression.QueryStringsWithRawDelegates();


Console.ReadLine();

static void QueryStringWithOperators()
{
    Console.WriteLine(">>>>> Using query expressions <<<<<");

    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "SystemShock 2" };

    var result = from game in currentVideoGames where game.Contains(" ") orderby game select game;

    foreach (var game in result)
    {
        Console.WriteLine(game);
    }
}

static void QueryStringsWithEnumerableAndLambdas()
{
    Console.WriteLine(">>>>> Using Enumerable / Lambda Expressions <<<<<");

    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "SystemShock 2" };

    // build the query using extension methods granted by Array Enumerable type.
    var result = currentVideoGames.Where(game => game.Contains(" "))
        .OrderBy(game => game)
        .Select(game => game);

    foreach (var item in result)            
    {
        Console.WriteLine(item);
    }
}

static void QueryStringsWithAnonymousMethods()
{
    Console.WriteLine(">>>>> Using Anonymous Methods <<<<<");

    string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "SystemShock 2"};

    // build the Func<> delegates using anonymous methods
    Func<string, bool> searchFilter = delegate(string game)
    {
        return game.Contains(" ");
    };
    Func<string, string> itemToProcess = delegate(string s)
    {
        return s;
    };

    // pass the delegates into the methods
    var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

    foreach (var item in subset)
    {
        Console.WriteLine(item);
    }
}