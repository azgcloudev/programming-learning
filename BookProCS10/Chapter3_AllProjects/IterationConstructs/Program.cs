ForLoopExample();  ForEachLoopExample();  LinqQueryOverInts();  //WhileLoopExample();  //DoWhileLoopExample();  IfElseExample();  IfElsePatternMatching();  IfElsePatternMatchingUpdatedInCSharp9();  Console.ReadKey();    // FOR LOOP static void ForLoopExample() {     // i is only visible within the scope of the for loop     for(int i = 0; i<4;i++)     {         Console.WriteLine("Number is: {0}", i);     }     // 'i' is not visible here     Console.WriteLine(); }   // using FOREACH static void ForEachLoopExample() {     string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };     foreach (string c in carTypes)     {         Console.WriteLine(c);     }      int[] myInts = { 10, 20, 30, 40 };     foreach (int i in myInts)     {         Console.WriteLine(i);     }     Console.WriteLine(); }  // implicit type using foreach static void LinqQueryOverInts() {     int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };      // LINQ query!     var subset = from i in numbers where i < 10 select i;     Console.WriteLine("Values in subset: ");      foreach (var i in subset)     {         Console.Write("{0} ", i);     }     Console.WriteLine(); }   // USING WHILE LOOP AND DO WHILE static void WhileLoopExample() {     string userIsDone = "";      // Test on a lower-class copy of the string      while(userIsDone.ToLower() != "yes")     {         Console.WriteLine("In the while loop");         Console.Write("Are you done? [yes] [no]: ");         userIsDone = Console.ReadLine();     }     Console.WriteLine(); }  static void DoWhileLoopExample()
{
    string userIsDone = "";

    do
    {
        Console.WriteLine("In do/while loop");
    Console.Write("Are you done? [yes] [no]: ");
    userIsDone = Console.ReadLine();
    } while (userIsDone.ToLower() != "yes");

    Console.WriteLine();
}


// USING IF/ELSE STATEMENTS
// only operates boolean expressions

// equality and relational operators
// == != < > <= >=

// CANNOT TEST A VALUE AGAINTS 0 OR -1
static void IfElseExample()
{
    Console.WriteLine("=> If/Else, with conditionals:");

    string stringData = "Mt textual data";
    //// this is iligal, given the length return an int, not a bool
    //if (stringData.Length)
    //{
    //    Console.WriteLine("string is greater than 0 characters");
    //}
    //else
    //{
    //    Console.WriteLine("string is not greater than 0 characters");
    //}


    // legal, as this resolves to either true or false
    if (stringData.Length > 0)
    {
        Console.WriteLine("string is greater than 0 characters");
    }

    Console.WriteLine();
}


// IF/ELSE PATTERN MATCHING
static void IfElsePatternMatching()
{
    Console.WriteLine("=> If else Pattern Matching:");

    object testItem1 = 123;
    object testItem2 = "Hello";

    if (testItem1 is String myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string");
    }

    if (testItem1 is int myValue1)
    {
        Console.WriteLine($"{myValue1} is an int");
    }

    if (testItem2 is String myStringValue2)
    {
        Console.WriteLine("{0} is a string", myStringValue2);
    }

    if (testItem2 is int myValue2)
    { 
        Console.WriteLine("{0} is an int", myValue2); 
    }

    Console.WriteLine();

}


// IMPROVED C#9.0 PATTERN MATCHING
static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("=> C# 9 If Else Pattern Matching Improvements:");

    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';

    // Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }

    // Relational, Conjuctive, and Disjunctive
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    }

    // Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
    }

    // negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }
    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }

    Console.WriteLine();
}