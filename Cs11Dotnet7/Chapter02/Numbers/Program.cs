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
        }
    }
}