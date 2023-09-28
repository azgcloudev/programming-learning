// if statement
WriteLine("--- If statement ---");
string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong.");
}

WriteLine();

// --- pattern matching statement ---
WriteLine("--- Pattern matching statement");
object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine($"o is not an int, so it cannot be multiplied.");
}

WriteLine();

// switch statement
WriteLine("--- Switch statement ---");
int number = Random.Shared.Next(1, 7);
WriteLine($"My random number is {number}.");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}
WriteLine("End of switch statement.");
A_label:
WriteLine($"After A_label");