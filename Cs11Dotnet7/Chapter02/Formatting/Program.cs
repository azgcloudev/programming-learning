// -- formatting with positional arguments ---
int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine("{0} apples cost {1:C}", arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// --- get input from user (console) ---
Console.Write("Type your first name and press ENTER: ");
string? firstName = Console.ReadLine();
Console.Write("Type your age and press ENTER: ");
string age = Console.ReadLine()!;
Console.WriteLine($"Hello {firstName}, you look good for {age}.");