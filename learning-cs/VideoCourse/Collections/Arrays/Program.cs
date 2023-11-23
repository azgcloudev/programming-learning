//declaration

int[] grades = new int[5]; // initialize an array of size 5

grades[0] = 11;
grades[1] = 12;
grades[2] = 13;
grades[3] = 15;
grades[4] = 23;

Console.WriteLine(grades[3]);

Console.Write("Update grade in position 3: ");
string input = Console.ReadLine()!;

if (int.TryParse(input, out int inputParsed))
{
    grades[3] = inputParsed;
}

Console.WriteLine(grades[3]);

// another way of initialize 
int[] gradesOfMathStudentsA = { 12, 3, 4, 5, 7, 8, 3 };

// and another way of initialize
int[] gradesOfMathStudentsB = new int[] { 5, 6, 7, 2, 3476, 23 };


// =================
// FOR loop and foreach loop
// =================
int[] nums = new int[10];

// array can get exception
try
{
    for (int i = 0; i < 11; i++)
    {
        //add values to each element
        nums[i] = i + 1;
    }

    Console.WriteLine("\n\n--- For Loop ---");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Element{0} = {1}", i, nums[i]);
    }
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Index out of range.");
}

// Use array length to avoid exception
for (int i = 0; i < nums.Length; i++)
{
    //add values to each element
    nums[i] = i + 1;
}

Console.WriteLine("\n\n--- For Loop ---");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine("Element{0} = {1}", i, nums[i]);
}


// foreach
Console.WriteLine("\n\n--- Foreach Loop ---");
int position = 0;
foreach (int number in nums)
{
    Console.WriteLine("Element{0} = {1}", position, number);
    position++;
}


//=================
// 2d arrays
//=================
Console.WriteLine("\n\n--- 2d Arrays ---");
int[,] array2D = new int[,]
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

// access value 5
Console.WriteLine("Center value is {0}", array2D[1, 1]);
// access value 7
Console.WriteLine("Position [2,0] is {0}", array2D[2, 0]);

// get array dimension
Console.WriteLine("array2D has {0} dimensions.", array2D.Rank);





Console.ReadKey();