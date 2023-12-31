﻿using static System.Convert;

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


Console.WriteLine();

// ===============================
// convert any type into string
// ===============================
WriteLine("=== Converting types to string ===");
int n = 12;
WriteLine(n.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());


Console.WriteLine();

// ===============================
// convert from binary object to string
// ===============================
WriteLine("=== Converting from a binary object to string ===");
// allocate array of 128 bytes
byte[] binaryObject = new byte[128];

// populate array with random bytes
Random.Shared.NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X} ");
}
WriteLine();

// convert to Base^4 string and output as text
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");



Console.WriteLine();

// ====================================================
// convert from strings to numbers and date time types
// ====================================================
WriteLine("=== Convert strings to numbers and date time ===");
int age = int.Parse("28");
DateTime birthday = DateTime.Parse("21 June 1995");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine("My birthday is {0:D}.", birthday);

// converting using tryparse to check if the value can be converted
Write("How many eggs are there? ");
string? countInput = ReadLine();

if (int.TryParse(countInput, out int count))
{
    WriteLine("There are {0} eggs.", count);
}
else
{
    WriteLine("The input could not be parsed");
}