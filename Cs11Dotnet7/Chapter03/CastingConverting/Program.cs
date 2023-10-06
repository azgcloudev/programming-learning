using static System.Convert;

// implicit casting (automatically)
int a = 10;
double b = a;
WriteLine($"int {a} assign to double b is {b}.");

// explicit casting (manually)
double c = 9.8;
// int d = c; // Program.cs(8,9,8,10): error CS0266: Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
//casting
int d = (int)c; // decimal points will be lost


long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

// converting values
double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}.");


Console.WriteLine();
//======================
// Rounding numbers
//======================
WriteLine("=== Rounding numbers ===");
double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double number in doubles)
{
    // System.Convert uses the bankers rounding rule
    WriteLine($"ToInt32({number}) is {ToInt32(number)}");

    // Using the Math class
    WriteLine($"\tMath.Round({number}), 0, MidpointRounding.AwayFromZero is {Math.Round(value: number, digits: 0, mode: MidpointRounding.AwayFromZero)}");
}