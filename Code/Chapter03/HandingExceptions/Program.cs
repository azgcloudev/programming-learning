using System;
using static System.Console;

namespace HandingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before Parsing");

            Write("What is your age? ");
            string input = ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (FormatException) // catch an specific exception and display custom message
            {
                WriteLine($"The age you entered \"{input}\" is not a valid format");
            }
            catch (OverflowException)
            {
                WriteLine($"The number enter is not valid, must be between {int.MinValue:N0} and {int.MaxValue:N0}.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");
        }
    }
}
