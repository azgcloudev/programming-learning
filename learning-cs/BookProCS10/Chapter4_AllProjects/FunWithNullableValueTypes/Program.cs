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