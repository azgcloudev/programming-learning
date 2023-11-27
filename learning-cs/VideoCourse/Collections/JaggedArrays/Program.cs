/*
* Jagged arrays are arrays inside another array
*/

// declaration
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[3];
jaggedArray[1] = new int[4];
jaggedArray[2] = new int[2];

jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5, 6, 7 };
jaggedArray[2] = new int[] { 8, 9 };

// another declaration
int[][] jaggedArray2 = new int[][]
{
    new int[] {1,2,3,4,5,6,7,8},
    new int[] {5,2,54}
};

// access a element in the array
Console.WriteLine("Middle element of the first array is {0}", jaggedArray2[0][4]);

// print all elements in the jagged array
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"{jaggedArray[i][j]} ");
    }
}
Console.Write("\n");


string[][] friendsFamilies = new string[][]
{
    new string[] {"Juan","Carlos"},
    new string[] {"Ana","Maria"},
    new string[] {"Rita", "Josh" }
};

// print exercise1
Console.WriteLine("\n\n");
Console.WriteLine("Hello {0} meet {1}", friendsFamilies[0][0], friendsFamilies[2][1]);
Console.WriteLine("Hello {0} meet {1}", friendsFamilies[1][0], friendsFamilies[1][1]);
Console.WriteLine("Hello {0} meet {1}", friendsFamilies[2][0], friendsFamilies[0][1]);