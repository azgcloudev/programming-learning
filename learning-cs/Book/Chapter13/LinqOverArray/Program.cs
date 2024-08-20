using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("***** Fun with LINQ to Objects *****");

QueryOverStrings();
QueryOverStringsWithExtensionMethods();
QueryOverStringsLongHand();
QueryOverInts();
DefaultWhenEmpty();
ImmediateExecution();
SettingDefaults();

// Console.ReadLine();


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

static void QueryOverInts()
{
    Console.WriteLine("\n***** Query Over Ints *****");

    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    
    // print only numbers less than 10
    // IEnumerable<int> subset = from i in numbers where i < 10 select 1;
    
    // use implicit typing
    var subset = from i in numbers where i < 10 select i;

    // foreach (int i in subset)
    foreach (var i in subset)
    {
        Console.WriteLine("Item: {0}", i);
    }

    Console.WriteLine();
    
    // deferred execution
    numbers[0] = 4;
    foreach (var i in subset)
    {
        Console.WriteLine("{0} < 10", i);
    }
    ReflecOverQueryResults(subset);
}

static void DefaultWhenEmpty()
{
    Console.WriteLine("\n***** Default when empty *****");
    List<int> numbers = new List<int>() { 10, 20, 30, 40, 1, 2, 3, 8 };
    
    // returns all the numbers
    foreach (var i in numbers.DefaultIfEmpty(-1))
    {
        Console.WriteLine("{0}", i);
    }

    Console.WriteLine();
    
    // return -1 since the sequence is empty
    foreach (var i in (from i in numbers where i > 99 select i).DefaultIfEmpty(-1))
    {
        Console.WriteLine($"{i}");
    }
    Console.WriteLine();
}

static void ImmediateExecution()
{
    Console.WriteLine();
    Console.WriteLine("\n***** Inmediate Execution *****");
    int[] numbers = new int[] { 10, 20, 30, 40, 1, 2, 3, 8 };
    
    // get the first element in sequence number
    int number = (from i in numbers select i).First();
    Console.WriteLine("First is {0}", number);

    // get the first in query order
    number = (from i in numbers orderby i select i).First();
    Console.WriteLine("First is {0}", number);

    // get the one element that matches the query
    number = (from i in numbers where i > 30 select i).Single();
    Console.WriteLine("Single is {0}", number);

    // return null if nothing is returned
    number = (from i in numbers where i > 99 select i).FirstOrDefault();
    number = (from i in numbers where i > 99 select i).SingleOrDefault();
    try
    {
        // throw an exception if no records found
        number = (from i in numbers where i > 99 select i).First();
    }
    catch (Exception ex)
    {
        Console.WriteLine("An exception occurred: {0}", ex.Message);
    }

    try
    {
        // throw an exception if no record found
        number = (from i in numbers where i > 99 select i).Single();
    }
    catch (Exception ex)
    {
        Console.WriteLine("An exception occurred: {0}", ex.Message);
    }

    try
    {
        //Throw an exception if more than one element passes the query
        number = (from i in numbers where i > 10 select 1).Single();
    }
    catch (Exception ex)
    {
        Console.WriteLine("An exception occurred: {0}", ex.Message);
    }

    // get data right now as int[]
    int[] subsetAsIntArray = (from i in numbers where i > 10 select i).ToArray<int>();
    Console.WriteLine(subsetAsIntArray.GetType().Name);

    // get data right now as List<int>
    List<int> subsetAsListOfInts = (from i in numbers where i > 10 select i).ToList<int>();
    Console.WriteLine(subsetAsListOfInts.GetType().Name);
}

static void ReflecOverQueryResults(object resultSet, string queryType = "Query Expressions")
{
    Console.WriteLine($"***** Info about your query using {queryType} *****");
    Console.WriteLine("resultSet is of type {0}", resultSet.GetType().Name);
    Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
}

static void SettingDefaults()
{
    Console.WriteLine("\n***** Defaults *****");
    int[] numbers = Array.Empty<int>();
    var query = from i in numbers where i > 100 select i;
    var number = query.FirstOrDefault(-1);
    Console.WriteLine(number);
    number = query.SingleOrDefault(-2);
    Console.WriteLine(number);
    number = query.LastOrDefault(-3);
    Console.WriteLine(number);
}