using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // set maximum number for the program
            int max = 100;

            // iterate over all the numbers and determine if
            // number divisible by 5 and 3 = FizzBuzz
            // divisible by 5 = Buzz
            // divisible by 3 = Fizz
            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Write("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Write("Buzz ");
                }
                else if (i % 3 == 0)
                {
                    Write("Fizz ");
                }
                // write in console the number
                else
                {
                    Write($"{i} ");
                }
            }
        }
    }
}
