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
            Console.Write("Enter another grade: ");
            string input = Console.ReadLine();
            grades[3] = int.Parse(input);
            Console.WriteLine("Grades at index 3: {0}", grades[3]);

            // other ways of declaration
            int[] mathGradesA = { 1, 2, 3, 4, 5 };

            // another option
            int[] mathGradesB = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Length of mathGradesB is {0}", mathGradesB.Length);


            // FOR EACH LOOP
            Console.WriteLine("\n------- FOR EACH ------");
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }

            Console.WriteLine("\n--- for each looping ---");
            foreach (int k in nums)
            {
                Console.WriteLine("nums = {0}", k);
            }


            string[] friends = new string[] { "Diego", "Randall", "Andres", "Juan", "Les" };
            Console.WriteLine("\n"); //white space
            foreach (string name in friends)
            {
                Console.WriteLine("Hello {0} welcome! Hope you are good.", name);
            }
        }
    }
}