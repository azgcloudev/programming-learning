using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 16;
            grades[2] = 42;
            grades[3] = 24;
            grades[4] = 30;

            Console.WriteLine("Grades at index 3: {0}", grades[3]);
            string input = Console.ReadLine();
            grades[3] = int.Parse(input);
            Console.WriteLine("Grades at index 3: {0}", grades[3]);

            // other ways of declaration
            int[] mathGradesA = { 1, 2, 3, 4, 5 };

            // another option
            int[] mathGradesB = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Length of mathGradesB is {0}", mathGradesB.Length);
            Console.ReadKey();
        }
    }
}