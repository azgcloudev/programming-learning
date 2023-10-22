using System;
using System.Collections.Generic;

namespace ListsC
{
    class Program
    {
        static void Main(string[] args)
        {
            // List contains elements of the same type only

            var numbers = new List<int>();
            var numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numbers3 = new List<int> { 5, 6, 7, 8, 9 };

            numbers2.Add(78);
            numbers2.Remove(5);

            foreach (int element in numbers2)
            {
                // TODO
            }

            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
        }
    }
}