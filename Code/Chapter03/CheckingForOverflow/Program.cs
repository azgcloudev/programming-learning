using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("----- Without checked -----");
            int x = int.MaxValue - 1;
            WriteLine($"Initial value: {x}");
            x++;
            WriteLine($"After incrementing: {x}");
            x++;
            WriteLine($"After incrementing: {x}");
            x++;
            WriteLine($"After incrementing: {x}");

            WriteLine("\n----- With checked -----");
            try
            {

                checked // if there is an exception for overflow it will be thrown hence use try cat to display
                        // error
                {
                    int y = int.MaxValue - 1;
                    WriteLine($"Initial value: {y}");
                    y++;
                    WriteLine($"After incrementing: {y}");
                    y++;
                    WriteLine($"After incrementing: {y}");
                    y++;
                    WriteLine($"After incrementing: {y}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("Got an overflow");
            }




            // ---------- DISABLE CHECKING OVERFLOW DURING COMPILATION ----------
            unchecked
            {
                int z = int.MaxValue + 1;
                WriteLine(z);

            }

        }
    }
}
