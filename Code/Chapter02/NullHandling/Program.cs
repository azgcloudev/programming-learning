using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string City = string.Empty;
        public string Region = string.Empty;
        public string Street = string.Empty;
    }


    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compile error
        
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            string? myName = "Aldair";
            Console.WriteLine(myName);
            myName = null;
            Console.WriteLine(myName);


            // ---------- DECLARE NON-NULLABLE VARIABLES ----------
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;


            // ---------- CHECKING FOR NULL ----------
            if (thisCouldBeNull != null)
            {
                // access a memember of thisCouldBeNull
                // int length = thisCouldBeNull.Length; //could thrown an exception
            }

            string authorName = null;

            // the following throws a NullReferenceException
            // int x = authorName.Length;

            // instead of throwing an exception, null is assigned to y
            // int? y = authorName.Length;

            // result will be 3 if authorName?.Length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);
        }
    }
}
