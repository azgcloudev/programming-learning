// import static file
using static System.Console;

// -- formatting with positional arguments ---
int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine("{0} apples cost {1:C}", arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// --- get input from user (console) ---
Write("Type your first name and press ENTER: ");
string? firstName = Console.ReadLine();
Write("Type your age and press ENTER: ");
string age = Console.ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}.");

// read a key or key combination from the customer
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifier: {2}", key.Key, key.KeyChar, key.Modifiers);

// end
ReadKey();