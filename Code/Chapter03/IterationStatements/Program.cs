using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- WHILE STATEMENT ----------
            WriteLine("----- While Statement -----");
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }




            // ---------- DO STATEMENT ----------
            WriteLine("\n----- Do Statement -----");
            string password = string.Empty;
            int tries = 1;   // trac password attemps

            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                tries++;
            }
            while (tries <= 10 & password != "Pa$$w0rd");
            if (tries >= 10)
            {
                WriteLine("Account lock, too many attempts");
            }
            else
            {
                WriteLine("Correct!");
            }




            // ---------- for statement -----------
            WriteLine("\n----- For Statement -----");
            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }




            // ---------- FOR EACH STATEMENT -----------
            WriteLine("\n----- Foreach statement -----");
            string[] names = { "Adam", "Berry", "Charlie" };

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters");
            }

            //under the hood
            System.Collections.IEnumerator e = names.GetEnumerator();

            while (e.MoveNext())
            {
                string name = (string)e.Current; // current is readonly
                WriteLine($"{name} has {name.Length} characters");
            }

        }
    }
}
