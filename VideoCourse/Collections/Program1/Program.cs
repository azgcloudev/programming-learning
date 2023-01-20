using System;

namespace Program1
{
    class Program
    {
        private static void InputedValue(string value)
        {
            Console.WriteLine("\nYou have entered the value: {0}", value);
        }

        private static void InvalidType(string type)
        {
            Console.WriteLine("It is an invalid: {0}", type);
        }

        private static void ValidType(string type)
        {
            Console.WriteLine("It is an valid: {0}", type);
        }


        static void Main(string[] args)
        {
            string valueInput = string.Empty;
            Console.Write("Enter a value: ");
            valueInput = Console.ReadLine();

            Console.WriteLine("\nSelect the Data Type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");
            Console.Write(": ");
            int type = int.Parse(Console.ReadLine());


            if (type == 3)
            {
                // check if is boolean
                if (valueInput.ToLower() == "true" || valueInput.ToLower() == "false")
                {
                    InputedValue(valueInput);
                    ValidType("Boolean");
                }
            }
            else if (type == 2)
            {
                bool isInteger = true;
                foreach (char ch in valueInput)
                {
                    if (Char.IsLetter(ch) != true && ch.ToString() != " ")
                    {
                        continue;
                    }
                    else
                    {
                        isInteger = false;
                        break;
                    }
                }

                if (isInteger)
                {
                    InputedValue(valueInput);
                    ValidType("Integer");
                }
                else
                {
                    InputedValue(valueInput);
                    InvalidType("Integer");
                }

            }
            else if (type == 1)
            {
                bool isString = false;

                foreach (char ch in valueInput)
                {
                    if (Char.IsLetter(ch) == true)
                    {
                        isString = true;
                    }
                }

                if (isString)
                {
                    InputedValue(valueInput);
                    ValidType("String");
                }
                else
                {
                    InputedValue(valueInput);
                    InvalidType("String");
                }
            }

        }
    }
}