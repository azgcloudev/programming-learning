ForLoopExample();

ForEachLoopExample();

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