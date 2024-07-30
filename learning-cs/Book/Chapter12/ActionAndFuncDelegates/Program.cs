Console.WriteLine("***** Fun with Action and Func *****");

// use the Action<> delegate to point to the DisplayMessage
Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
actionTarget("Action Message!", ConsoleColor.Yellow, 5);

// using the Func<> delegate
Func<int, int, int> funcTarget = Add;
int result = funcTarget(2, 3);
Console.WriteLine(result);

Func<int, int, string> funcTarget2 = SumToString;
string result2 = funcTarget2(5, 7);
Console.WriteLine(result2);

Console.ReadKey();

// this is a target for the Action<> delegate
static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
{
    // set color of console
    ConsoleColor previous = Console.ForegroundColor;
    Console.ForegroundColor = txtColor;

    for (int i = 0; i < printCount; i++)
    {
        Console.WriteLine(msg);
    }

    // restore color
    Console.ForegroundColor = previous;
}

// target for the Func<> delegate
static int Add(int x, int y)
{
    return x + y;
}

// target for the Func<> delegate (with another return type
static string SumToString(int x, int y)
{
    return (x + y).ToString();
}