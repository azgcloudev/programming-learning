namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer 0 or positive
            uint naturalNumber = 23;

            // integer
            int integerNumber = -23;

            // float, fractional number
            float realNumber = 2.3F;

            // double precision (fractional default type)
            double anotherRealNumber = 2.3;


            // digit number separator (+ c#7.0)
            int decimalNotation = 2_000_000; // output will be 1000000

            // binary and hexadecimal notation
            Console.WriteLine("--- Binary and hexadecimal notation");
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            //all numbers are the same
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            // size of types
            Console.WriteLine();
            Console.WriteLine($"Int has a size of {sizeof(int)} bytes. Its minimum value is {int.MinValue}\tand max value is {int.MaxValue}.");
            Console.WriteLine();
            Console.WriteLine($"Double has a size of {sizeof(double)} bytes. Its minimum value is {double.MinValue:N0}\tand max value is {double.MaxValue:N0}.");
            Console.WriteLine();
            Console.WriteLine($"Decimal has a size of {sizeof(decimal)} bytes. Its minimum value is {decimal.MinValue:N0}\tand max value is {decimal.MaxValue:N0}.");
        }
    }
}