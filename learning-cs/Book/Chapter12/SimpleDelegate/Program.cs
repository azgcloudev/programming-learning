using System;

namespace SimpleDelegate
{
    internal class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            SimpleMath m = new SimpleMath();

            // Create a BinaryOp delegate object that "points to" Simplemath.Add();
            BinaryOp b = new BinaryOp(m.Add);

            // the following makes a compile error, because the method doesn't follow
            // the delegate parameters:
            /*
             * error CS0123: No overload for 'SquareNumber' matches delegate 'Program.BinaryOp'
                BinaryOp s = m.SquareNumber;
             */

            // invoke the Add() method indirectly using the delegate object
            Console.WriteLine("10 + 10 is {0}", b(10,10));
            Console.ReadLine();


            // display delagte info
            DisplayDelegateInfo(b);
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            // print the name of each member in the delegate's invocation list
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
    }
}
