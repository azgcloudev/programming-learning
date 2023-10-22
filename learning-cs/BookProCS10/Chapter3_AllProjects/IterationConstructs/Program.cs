ForLoopExample();  ForEachLoopExample();  LinqQueryOverInts();  //WhileLoopExample();  //DoWhileLoopExample();  IfElseExample();  IfElsePatternMatching();  IfElsePatternMatchingUpdatedInCSharp9();  ExacuteIfElseUsingConditionalOperator();  ConditionalRedExample();  SwitchExample();  SwitchOnEnumExample();  ExecutePatternMatchingSwitch();  ExecutePatternMatchingSwitchWithWhen();  Console.WriteLine(FromRainbowClassic("Red"));  Console.WriteLine(RockPaperScissors("rock","paper"));   Console.ReadKey();    // FOR LOOP static void ForLoopExample() {     // i is only visible within the scope of the for loop     for(int i = 0; i<4;i++)     {         Console.WriteLine("Number is: {0}", i);     }     // 'i' is not visible here     Console.WriteLine(); }   // using FOREACH static void ForEachLoopExample() {     string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };     foreach (string c in carTypes)     {         Console.WriteLine(c);     }      int[] myInts = { 10, 20, 30, 40 };     foreach (int i in myInts)     {         Console.WriteLine(i);     }     Console.WriteLine(); }  // implicit type using foreach static void LinqQueryOverInts() {     int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };      // LINQ query!     var subset = from i in numbers where i < 10 select i;     Console.WriteLine("Values in subset: ");      foreach (var i in subset)     {         Console.Write("{0} ", i);     }     Console.WriteLine(); }   // USING WHILE LOOP AND DO WHILE static void WhileLoopExample() {     string userIsDone = "";      // Test on a lower-class copy of the string      while(userIsDone.ToLower() != "yes")     {         Console.WriteLine("In the while loop");         Console.Write("Are you done? [yes] [no]: ");         userIsDone = Console.ReadLine();     }     Console.WriteLine(); }  static void DoWhileLoopExample()
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


// USING CONDITIONAL OPERATOR
// ternary conditional operator
// condition ? first_expression : second_expression;

static void ExacuteIfElseUsingConditionalOperator()
{
    Console.WriteLine("=> Conditional Operator:");

    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters");

    Console.WriteLine();
}

// conditional reference
static void ConditionalRedExample()
{
    int[] smallArray = new int[] { 1, 2, 3, 4, 5 };
    int[] largeArray = new int[] { 10, 20, 30, 40, 50 };

    int index = 7;

    ref int refValue = ref ((index < 5)
        ? ref smallArray[index]
        : ref largeArray[index - 5]);
    refValue = 0;

    index = 2;
    ((index < 5)
        ? ref smallArray[index]
        : ref largeArray[index - 5]) = 100;

    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));

    Console.WriteLine();
}


// LOGICAL OPERATORS
// AND, OR , NOT
// AND && all evaluations must be true
// OR || at least one evaluation be true
// NOT ! if false returns true, if true returns false



// THE SWITCH STATEMENT
static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");

    string langChoice = Console.ReadLine();
    int n = int.Parse(langChoice);

    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }

    Console.WriteLine();
}


// switch with ENUM
static void SwitchOnEnumExample()
{
    Console.Write("Enter your favorite day of the week: ");
    DayOfWeek favDay;

    try
    {
        favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input!");
        return;
    }

    switch (favDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Football!!");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it is not Monday");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost Friday...");
            break;
        // cases can be put togetter for a same result action
        case DayOfWeek.Friday:
        case DayOfWeek.Saturday:
            Console.WriteLine("It's weekend!");
            break;
    }

    Console.WriteLine();
}


// PATTERN MATCHING IN SWITCH STATEMENT
static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice;
    // this is a standard constant pattern switch statement to set up the example
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5M;
            break;
        default:
            choice = 5;
            break;
    }

    // this is the new pattern matching switch statement
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer {0}.", i);
            break;
        case string s:
            Console.WriteLine("Your choice is a string {0}", s);
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal {0}", d);
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
    Console.WriteLine();
}

static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");

    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, c# is a fine language.");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}


// USING SWITCH EXPRESSIONS (NEW 8.0)
static string FromRainbowClassic(string colorBand)
{
    //switch (colorBand)
    //{
    //    case "Red":
    //        return "#FF0000";
    //        break;
    //    case "Orange":
    //        return "#FF7F00";
    //        break;
    //    case "Yellow":
    //        return "#FFFF00";
    //        break;
    //    case "Green":
    //        return "#00FF00";
    //        break;
    //    case "Blue":
    //        return "#0000FF";
    //        break;
    //    case "Indigo":
    //        return "#3B0082";
    //        break;
    //    case "Violet":
    //        return "#9400D3";
    //        break;
    //    default:
    //        return "#FFFFFF";
    //        break;
    //}

    //// can be written also as:
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        _ => "#FFFFFF" // default
    };
}


// switch using tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock","paper") => "Paper wins.",
        ("rock","scissors") => "Rock wins.",
        ("paper","rock") => "Paper wins.",
        ("paper","scissors") => "Scissors wins.",
        ("scissors","rock") => "Rock wins.",
        ("scissors","paper") => "Scissors wins.",
        (_,_) => "Tie.",
    };
}