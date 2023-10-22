using System;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("Hello", "String", "Aldair", "Keywords");

            int number = 1;
            char symbol = '$';
            string name = "Aldair";
            float pi = 3.1415F;

            ParamsMethod2(number, symbol, name, pi);

            // Get int min value from array using params
            int[] numbers = { 2345, 1234, 23456, 2134, 2345, 712324, 234 };

            Console.WriteLine("The minimum number is {0}", MinV2(numbers));
        }

        // params allows to enter multiple values

        static void ParamsMethod(params string[] words)
        {
            //print each string in the parameters
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        static void ParamsMethod2(params object[] obj)
        {
            foreach (object str in obj)
            {
                // objects has a string method
                Console.WriteLine(str);
            }
        }


        public static int MinV2(params int[] numbers)
        {
            // defines the maximum int number avialable as an initial value for the minimum
            int min = int.MaxValue;

            // loop through all numbers array and assign assign the minimum to 'min'
            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;
            }

            return min;
        }
    }
}