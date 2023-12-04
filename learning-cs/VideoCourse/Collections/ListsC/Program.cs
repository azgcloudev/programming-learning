namespace ListsC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // to use List need to import the System.Collections.Generic

            // declaration with 0 elements
            List<int> numbers = new List<int>();

            // declaration using elements
            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // foreach loop
            foreach (int i in numbers1)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // for loop
            for(int i = 0; i < numbers1.Count; i++)
            {
                Console.Write("{0} ", numbers1.ElementAt(i));
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}