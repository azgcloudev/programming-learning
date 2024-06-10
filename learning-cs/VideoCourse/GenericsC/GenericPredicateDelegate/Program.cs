using System;

namespace GenericPredicateDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;

            // use the predicate when a function allows it
            // like the following

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumbers = numbers.FindAll(isEven);

            Console.Write("[ ");
            foreach (var number in evenNumbers)
            {
                Console.Write("{0} ", number);
            }
            Console.Write("]");
        }
    }
}
