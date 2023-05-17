ForLoopExample();

ForEachLoopExample();

LinqQueryOverInts();

Console.ReadKey();



// FOR LOOP
static void ForLoopExample()
{
    // i is only visible within the scope of the for loop
    for(int i = 0; i<4;i++)
    {
        Console.WriteLine("Number is: {0}", i);
    }
    // 'i' is not visible here
    Console.WriteLine();
}


// using FOREACH
static void ForEachLoopExample()
{
    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
    foreach (string c in carTypes)
    {
        Console.WriteLine(c);
    }

    int[] myInts = { 10, 20, 30, 40 };
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

// implicit type using foreach
static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    // LINQ query!
    var subset = from i in numbers where i < 10 select i;
    Console.WriteLine("Values in subset: ");

    foreach (var i in subset)
    {
        Console.Write("{0} ", i);
    }
    Console.WriteLine();
}