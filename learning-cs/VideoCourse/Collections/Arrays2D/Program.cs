int[,] matrix =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

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
        if (i == j)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
    }
}

// print diagonal
Console.WriteLine("\n\n-- diagonal ---");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    //print second row
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j)
        {
            Console.WriteLine(matrix[i, j]);
        }
    }
}

Console.WriteLine("\n\n--- Reverse diagonal ---");
for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
{
    Console.WriteLine(matrix[i, j]);
}