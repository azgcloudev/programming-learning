using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // What will happen if this code executes?
            /*
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
            */
            // loop because byte cannot get into 500, will be an overflow



            // What code could you add (don't change any of the preceding code) to warn us about
            // the problem
            try
            {

                checked
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow, internal error");
            }

            
        }
    }
}
