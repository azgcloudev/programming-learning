using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------- IMPLICIT CASTING ----------
            int a = 10;
            double b = a; // an int can be safely cast into a double (implicit cast)
            WriteLine(b);

            /*
            double c = 9.8;
            int d = c; // compiler gives an error in this line
            WriteLine(d);
            */


            // ---------- EXPLICIT CASTING ----------
            double c = 9.8;
            int d = (int)c;
            WriteLine(d); // d will lose the decimals


            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");




            // ---------- CONVERT WITH System.Convert ----------
            WriteLine("\n----- SYSTEM CONVERT -----");
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");




            // ----------- SYSTEM CONVERT ROUNDING ----------
            WriteLine("\n----- System.Convert Rounding -----");
            double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            // round using the Round method from Math class
            WriteLine("--> Rouding with System.Convert <--");
            foreach (double n in doubles)
            {
                WriteLine(format:
                "Math.Round({0}), 0, MidPointRounding.AwayFromZero) is {1}",
                arg0: n,
                arg1: Math.Round(value: n,
                        digits: 0,
                        mode: MidpointRounding.AwayFromZero)
                );
            }




            // ---------- CONVERT ANY TYPE TO STRING ----------
            WriteLine("\n----- Converting any type into string -----");
            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());



            // ---------- CONVERT FROM BINARY OBJECT TO STRING ----------
            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];
            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary Object as bytes:");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X} ");
            }
            WriteLine();

            // convert to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");




            // ---------- PARSE FROM STRING TO NUMBERS OR DATE AND TIME ----------
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("21 June 1995");
            WriteLine($"I was born {age} years ago");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            // int count = int.Parse("abc"); // throws an exception
            /*
            Unhandled exception. System.FormatException: Input string was not in a correct format.
   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Number.ParseInt32(ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info)
   at System.Int32.Parse(String s)
   at CastingConverting.Program.Main(String[] args) in C:\Users\aldairzamora\Documents\Programming\learning-cs\Code\Chapter03\CastingConverting\Program.cs:line 117
   */

            // ----------- TRYPARSE -----------
            WriteLine("\n----- TryParse -----");
            Write("How many eggs are there? ");
            int count;
            string input = ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs");
            }
            else
            {
                WriteLine("I could not parse the input");
            }

        }
    }
}
