using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for number between 0-255
            // divide first number by second number

            Console.Write("Enter a number between 0-255: ");
            string number1 = Console.ReadLine();
            Console.Write("Enter another number between 0-255: ");
            string number2 = Console.ReadLine();

            int number1Int, number2Int;

            if (int.TryParse(number1, out number1Int) && int.TryParse(number2, out number2Int))
            {
                Console.WriteLine($"{(double)number1Int / number2Int:N2}");
            }
            else
            {
                if (number1 != string.Empty)
                {
                    try
                    {
                        number1Int = int.Parse(number1);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.GetType()} {ex.Message} '{number1}' is not a number.");
                    }
                }

                if (number2 != string.Empty)
                {
                    try
                    {
                        number2Int = int.Parse(number2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.GetType()} {ex.Message} '{number2}' is not a number.");
                    }
                }

            }

            // ------ TEST -----
            // guess the result
            int x = 3;
            int y = 2 + ++x;
            Console.WriteLine($"y is {y}"); // 6
            
            // 128 64 32 16   8 4 2 1
            // 3 = 0000 00011
            // 10 = 0000 1010
            x = 3 << 2; // 1100 = 12
            Console.WriteLine($"3 << 2 = {x}"); // 12
            y = 10 >> 1; // 0101
            Console.WriteLine($"10 >> 1 = {y}");  //5


            x = 10 & 8;
            Console.WriteLine($"10 & 8 = {10 & 8}");
            y = 10 | 7;
            Console.WriteLine($"10 | 7 = {10 | 7}");
        }
    }
}
