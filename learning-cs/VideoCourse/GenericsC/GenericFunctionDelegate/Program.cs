using System.Diagnostics;

namespace GenericFunctionDelegate
{
    internal class Program
    {
        private const int CurrentYear = 2024;

        static void Main(string[] args)
        {
            // function<> does provide a return type

            Func<int, int> getAgeByYear = (birthYear) => CurrentYear - birthYear;

            Console.WriteLine("What is your birth year? ");
            int birthYear;
            int age = -1;

            try
            {
                birthYear = int.Parse(Console.ReadLine());
                age = getAgeByYear(birthYear);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to parse input");
            }

            if (age != -1)
            {
                Console.WriteLine("Current age is {0}", age);
            }
            else
            {
                Console.WriteLine("Not a valid number input, unable to calculate age.");
            }
        }
    }
}
