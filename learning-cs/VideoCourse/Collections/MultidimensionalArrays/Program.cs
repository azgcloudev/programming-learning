using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare 2d array
            int[,] matrix =
            {
                { 11, 12, 13 },
                { 14, 15, 16 },
                { 17, 18, 19 }
            };

            // declare 3d array
            int[,,] threeD;

            // initialize
            int[,] array2d = new int[,]
            {
                {1,2,3},    // row 0
                {4,5,6 },   // row 1
                {7,8,9 }    // row 2
            };

            Console.WriteLine("Central value is {0}", array2d[1, 1]);
            Console.WriteLine("Access the seven: {0}", array2d[2, 0]);

            // 3D
            int[,,] array3D = new int[,,]
            {
                {
                    {1,2,3 },
                    {4,5,6 }
                },
                {
                    {10,11,12 },
                    {13,14,15 }
                }
            };
            Console.WriteLine("3D array array3D[0,0,2] is {0}", array3D[0, 0, 2]);

            // another methofd to initialize and declare
            int[,] initializeArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };



            // ----- NESTED FOR LOOPSIN 2D ARRAYS -----
            Console.WriteLine("\n----- foreach -----");
            foreach (int item in matrix)
            {
                Console.WriteLine(item + " ");
                //item = 4; // cannot be modify using a foreach
            }

            Console.WriteLine("\n---- for loop -----");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
            }


            // print only even numbers from the matrix array
            Console.WriteLine("\nprint only even numbers from the matrix array");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.WriteLine(matrix[i, j] + " ");
                    }
                }
            }



            // print diagonal values
            Console.WriteLine("\nprint diagonal values");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }

            Console.WriteLine("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 && j == 2 || i == 1 && j == 1 || i == 2 && j == 0)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
            }

        }
    }
}