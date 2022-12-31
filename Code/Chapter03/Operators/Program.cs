using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;    // postfix operator
            WriteLine($"a is {a}, b is {b}.");

            int c = 3;
            int d = ++c;
            WriteLine($"c is {c}, d is {d}.");


            // ---------- BINARY ARITHMETIC OEPERATORS ----------
            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}.");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f = {g / f}");


            // ---------- ASSIGMENT OPERATORS ----------
            int p = 6;
            p += 3; // p = p + 4
            p -= 3;
            p *= 3;
            p /= 3;

        }
    }
}
