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