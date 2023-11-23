int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

// == nested for loop ==

// print first row
for (int i = 0; i < matrix.GetLength(0); i++)
{
    //print second row
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("{0} ", matrix[i, j]);
    }
}

Console.WriteLine("\n\n-- Printing odd numbers from matrix ---");
// print only odd numbers
for (int i = 0; i < matrix.GetLength(0); i++)
{
    //print second row
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] % 2 != 0)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
    }
}
