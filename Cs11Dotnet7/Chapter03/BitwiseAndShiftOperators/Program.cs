
// AND, OR , XOR bitwise operators
using System.Security.Cryptography;

int a = 10;
int b = 6;

WriteLine($"a = {a}"); // 00001010
WriteLine($"b = {b}"); // 00000110
WriteLine($"a & b = {a & b}"); // 2-bit column only e.g. 00000010
WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns e.g. 00001110
WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns e.g. 00001100

WriteLine();

// left and right shift operator
WriteLine("--- Left and right shift operator ---");
WriteLine($"a << 3 = {a << 3}");
WriteLine($"a * 8 = {a * 8}");
WriteLine($"b >> 1 = {b >> 1}");

WriteLine();
WriteLine("Outputting integers as binary:");
WriteLine($"a =       {ToBinaryString(a)}");
WriteLine($"b =       {ToBinaryString(b)}");
WriteLine($"a & b =   {ToBinaryString(a & b)}");
WriteLine($"a | b =   {ToBinaryString(a | b)}");
WriteLine($"a ^ b =   {ToBinaryString(a ^ b)}");

// FUNCTIONS

// convert decimal to binary
static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}