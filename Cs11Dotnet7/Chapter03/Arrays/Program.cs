// ==== Single dimension arrays ===
string[] names; // can reference any size array of strings

// allocate memory for four strings in the array
names = new string[4];

// store items at index position
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// looping through the names
for (int i = 0; i < names.Length; i++)
{
    // output the item at an index position
    WriteLine(names[i]);
}

// array initializer syntax
string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };


//==========================
//Multidimensional arrays
//=========================

string[,] grid1 = new[,]
{
    {"Alpha","Beta","Gamma","Delta" },
    {"Anne","Ben","Charlie","Doug" },
    {"Aardvark","Bear","Cat","Dog" }
};

WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

// loop with nested for, to get values
for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
    {
        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
    }
}



//==================
//jagged arrays
//==================
WriteLine($"\n\n--- Jagged arrays ---");
string[][] jagged = new[]
{
    new[] { "Alpha", "Beta", "Gamma", "Delta" },
    new[] {"Anne","Ben","Charlie","Doug" },
    new[] {"Aardvark","Bear","Cat","Dog" }
};

WriteLine("Upper bound of array of arrays is: {0}", jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
    WriteLine("Upper bound array {0} is: {1}", array, jagged[array].GetUpperBound(0));
}