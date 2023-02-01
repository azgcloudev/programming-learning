using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array inside an array
            int[][] jaggedArray = new int[3][]; // 3 arrays inside an array

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 3, 5 };

            // alternative way:
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 4, 5, 6, 7 },
                new int[] { 2, 5, 6 },
                new int[] { 5, 6 }
            };

            Console.WriteLine("The value in the middle of the first entre is {0}", jaggedArray2[0][2]);

            // all the values of the array
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray2[i][j]);
                }
            }

        }

    }
}