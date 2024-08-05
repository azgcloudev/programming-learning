using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("***** Fun with LINQ to Objects *****");

QueryOverStrings();
QueryOverStringsWithExtensionMethods();
QueryOverStringsLongHand();

Console.ReadLine();


static void QueryOverStrings()
{
    // array of strings
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
    
    // linq query to find the items with an embedded space
    IEnumerable<string> subset = from g in currentVideoGames
        where g.Contains(" ")
        orderby g
        select g;
    
    ReflecOverQueryResults(subset);
    
    // print the results
    foreach (string s in subset)
    {
        Console.WriteLine("Item: {0}", s);
    }

    Console.WriteLine();
}

static void QueryOverStringsWithExtensionMethods()
{
    // array of strings
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
    
    // linq query using extension methods
    var subset = 
        currentVideoGames.Where(g => g.Contains(' ')).OrderBy(g => g).Select(g => g);
    
    ReflecOverQueryResults(subset, "Extension method");
    
    // print
    Console.WriteLine("\nUsing extension methods:");
    foreach (string s in subset)
    {
        Console.WriteLine("Item: {0}", s);
    }
}

static void QueryOverStringsLongHand()
{
    // array of strings
    string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

    string[] gameWithSpaces = new string[5];

    for (int i = 0; i < currentVideoGames.Length; i++)
    {
        if (currentVideoGames[i].Contains(' '))
        {
            gameWithSpaces[i] = currentVideoGames[i];
        }
    }
    
    // sort the new array
    Array.Sort(gameWithSpaces);
    
    // print results
    Console.WriteLine("\nOld School version:");
    foreach (string s in gameWithSpaces)
    {
        if (s != null)
        {
            Console.WriteLine("Item: {0}", s);
        }
    }
}

static void ReflecOverQueryResults(object resultSet, string queryType = "Query Expressions")
{
    Console.WriteLine($"***** Info about your query using {queryType} *****");
    Console.WriteLine("resultSet is of type {0}", resultSet.GetType().Name);
    Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
}