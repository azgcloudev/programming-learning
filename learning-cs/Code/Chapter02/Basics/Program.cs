﻿using System;   // semicolon indicates end of statement
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {   // start of a block
            Console.WriteLine("Hello World!");  // statement

            // ---------------------------------------------------------------

            // declare ununsed variables
            // in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            // loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly()
            .GetReferencedAssemblies())
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // declare a variable to count the number of methods
                int methodCount = 0;
                // loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                // output the count of types and their methods
                Console.WriteLine(
                "{0:N0} types with {1:N0} methods in {2} assembly.",
                arg0: a.DefinedTypes.Count(),
                arg1: methodCount,
                arg2: r.Name);
            }


            // --------- NAMING THINGS AND ASSIGNING VALUES ----------------
            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has thevalue {heightInMetres}.");

            // ---------- STORING TEXT -------------------------------
            string firstName = "Bob"; // assigning literal stri
            Console.WriteLine(firstName);


            // ----------- VERBATIM STRINGS ----------
            string filePath = @"C\televisions\sony\bravia.txt"; // prevents the \t to be read as an escape sequence
            Console.WriteLine(filePath);

        }   // end of a block
    }
}