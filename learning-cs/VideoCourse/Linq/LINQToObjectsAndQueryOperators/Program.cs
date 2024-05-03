using System;

using LINQToObjectsAndQueryOperators;

UniversityManager um = new UniversityManager();

um.MaleStudents();
um.FemaleStudents();
Console.WriteLine();
um.StudentsSortByAge();

Console.WriteLine();
um.AllStudentsFromBeijinTech();

Console.WriteLine();
um.StudentsFromId(GetUniversityInputId());

Console.WriteLine();
Console.WriteLine("Ordering numbers:");
// ordering ints and reverse them
int[] someInts = new int[] { 30, 12, 4, 3, 12 };
var sortedInts = from i in someInts orderby i select i;
// reverse the numbers
var sortedIntsReversed = sortedInts.Reverse();
// another option to reverse
var sortedReverseLinq = from i in someInts orderby i descending select i;

foreach (int i in sortedInts)
{
    Console.WriteLine(i);
}
Console.WriteLine();
foreach (int i in sortedIntsReversed)
{
    Console.WriteLine(i);
}
Console.WriteLine();
foreach (int i in sortedReverseLinq)
{
    Console.WriteLine(i);
}
um.StudentAndUniversityNameCollection();

Console.ReadKey();
// end of main class

///
/// Returns -1 if input cannot be parse to a number.
///
static int GetUniversityInputId()
{
    Console.Write("Enter the university ID number: ");

    string inputStr = Console.ReadLine();

    if (int.TryParse(inputStr, out int uId))
    {
        return uId;
    }

    return -1;
}