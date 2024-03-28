namespace NullablesT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nullable variables
            int? num1 = null;
            int? num2 = 9;
            bool? boolval = new bool?();

            Console.WriteLine($"Numbers values are {num1}, {num2}");
            Console.WriteLine("Boolean value is {0}", boolval);

            int? age = null;
            if (age != null)
            {
                Console.WriteLine($"Your age is {age}");
            }
            else
            {
                Console.WriteLine("Age is not set.");
            }

            // NULL COALESCING OPERATOR
            int num9;
            num9 = num1 ?? -1; // if num1 is null then assign -1
            Console.WriteLine($"num9 is {num9}");
            num9 = num2 ?? -1;
            Console.WriteLine($"num9 is {num9}");

            Console.ReadKey();
        }
    }
}
