using System;

namespace SimpleDelegate
{
    internal class Program
    {
        public delegate int BinaryOp(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            // Create a BinaryOp delegate object that "points to" Simplemath.Add();
            BinaryOp b = new BinaryOp(SimpleMath.Add);

            // the following makes a compile error, because the method doesn't follow
            // the delegate parameters:
            /*
             * error CS0123: No overload for 'SquareNumber' matches delegate 'Program.BinaryOp'
                BinaryOp s = SimpleMath.SquareNumber;
             */

            // invoke the Add() method indirectly using the delegate object
            Console.WriteLine("10 + 10 is {0}", b(10,10));
            Console.ReadLine();
        }
    }
}
