int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

OddNumbers(numbers);

Console.ReadKey();
// end of program

static void OddNumbers(int[] numbers)
{
    Console.WriteLine("Odd numbers:");

    IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number; // linq statement

    foreach(int num in oddNumbers)
    {
        Console.WriteLine(num);
    }
}