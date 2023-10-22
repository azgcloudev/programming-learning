using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall");

            // int length1 = name.Length; // gives compile error
            int length2 = ((string)name).Length; // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} characters.");

            // ---------- DYNAMIC TYPES ----------
            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a
            // property named Length
            int length = anotherName.Length;


            // ---------- LOCAL VARIABLES ----------
            int population = 66_000_000; // 66 million in UK
            double weight = 1.88; // in kilograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // strings use double-quotes
            char letter = 'Z'; // chars use single-quotes
            bool happy = true; // Booleans have value of true or false


            // // --- good use of var because it avoids the repeated type
            // // --- as shown in the more verbose second statement
            // var xml1 = new XmlDocument();
            // XmlDocument xml2 = new XmlDocument();

            // // --- bad use of var because we cannot tell the type, so we
            // // --- should use a specific type declaration as shown in
            // // --- the second statement
            // var file1 = File.CreateText(@"C:\something.txt");
            // StreamWriter file2 = File.CreateText(@"C:\something.txt");

            // ----------- DEFAULT VALUE TYPES ----------
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

        }
    }
}