Console.WriteLine("***** LINQ Return Values *****\n");

IEnumerable<string> subset = GetStringSubset();

foreach (string item in subset)
{
    Console.WriteLine(item);
}

// inmediate execution
Console.WriteLine("\n***** Immediate execution *****");
foreach (var item in GetStringSubsetAsArray())
{
    Console.WriteLine(item);
}


// =====================================

static IEnumerable<string> GetStringSubset()
{
    string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
    // note that subset is IEnumerable<string> compatible
    IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
    return theRedColors;
}

static string[] GetStringSubsetAsArray()
{
    string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };

    var theRedColors = from c in colors where c.Contains("Red") select c;
    
    // use inmediate execution
    return theRedColors.ToArray();
}