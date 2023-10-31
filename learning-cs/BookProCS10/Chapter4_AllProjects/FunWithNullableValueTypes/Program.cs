using System;

namespace FunWithNullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Value Types *****\n");

            DatabaseReader dr = new DatabaseReader();

            // Get int from database
            int? i = dr.GetIntFromDatabase();

            // check if i is null or has a value
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is {0}.", i);

            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined.");
            }

            // Get bool from database
            bool? b = dr.GetBoolFromDatabase();
            // check if it has value
            if (b != null)
            {
                Console.WriteLine("Value of 'b' is {0}.", b);
            }
            else
            {
                Console.WriteLine("Value of 'b' is undefined.");
            }

            //nullable coalescing operator
            // assigns a value if the retrive value is null
            DatabaseReader dr2 = new DatabaseReader();
            int myData = dr2.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}.", myData);



            // null coalescing assigment operator ??=
            Console.WriteLine("\n\nNull coalescing assigment operator");
            /**
             * Assigns the right side value to the left side, only if the left side value is null.
             */
            int? nullInt = null;
            nullInt ??= 12;
            nullInt ??= 14;
            Console.WriteLine(nullInt);

            // null conditional
            Console.WriteLine("\n\nnull conditional operator");
            TesterMethod(null);

            Console.ReadLine();
        }

        static void LocalNullableVariables()
        {
            // defining local nullable variables
            int? nullableInt = 10;
            double? nullableDouble = 3.15;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] nullableIntArray = new int?[3];

            // nullable
            Nullable<int> age = null;
        }

        // ===== Null conditional operator =====
        static void TesterMethod(string[] args)
        {
            // option 1, without null conditional operator
            if (args != null)
            {
                Console.WriteLine("You sent me {0} arguments.", args.Length);
            }
            else
            {
                Console.WriteLine("You sent me {0} arguments.", 0);
            }

            // option 2, with conditional null operator 
            Console.WriteLine("You sent me {0} arguments.", args?.Length ?? 0);

        }
    }

    class DatabaseReader
    {
        // ===============================================================
        // simulation to retrieve data from a database that might by with
        // empty values
        // ===============================================================

        // nullable data field
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
}