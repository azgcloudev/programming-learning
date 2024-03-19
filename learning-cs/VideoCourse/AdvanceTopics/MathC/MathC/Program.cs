namespace MathC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The ceil of 15.34 is {0}.", Math.Ceiling(15.34));
            Console.WriteLine("The floor of 23.12 is {0}.", Math.Floor(23.12));

            int num1 = 9;
            int num2 = 13;
            Console.WriteLine($"Lower of num1 {num1} and num2 {num2} is {Math.Min(num1, num2)}");
            Console.WriteLine($"Higher of num1 {num1} and num2 {num2} is {Math.Max(num1, num2)}");

            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}.");
            Console.WriteLine("PI number is = {0}", Math.PI);

            Console.WriteLine($"The square root of 25 is {Math.Sqrt(25)}");
            Console.WriteLine($"-4.78 always positive is {Math.Abs(-4.78)}");
            Console.WriteLine("Cos of 1 is: {0}", Math.Cos(1));
        }
    }
}
