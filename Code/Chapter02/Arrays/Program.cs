using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------- STORING MULTIPLE VALUES [arrays] ----------
            string[] names; // Can reference any array of strings

            // allocating memory for 4 strings in the array
            names = new string[4];

            // storing names at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            // looping through the names
            for (int i = 0; i < names.Length; i++ )
            {
                // out the item at index i
                Console.WriteLine(names[i]);
            }

            
        }
    }
}
