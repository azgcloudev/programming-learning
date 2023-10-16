// FizzBuzz

// number divisible by three = fizz
// number divisible by five = buzz
// number divisible by three and five = fizzbuzz

// do fizzbuzz from 1 to 100 numbers

for (int i = 1; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.Write("FizzBuzz, ");
    }
    else if (i % 5 == 0)
    {
        Console.Write("Buzz, ");
    }
    else if (i % 3 == 0)
    {
        Console.Write("Fizz, ");
    }
    else
    {
        Console.Write("{0}, ", i);
    }
}