using System;
using System.Collections.Generic;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a stack
            Stack<int> firstStack = new Stack<int>();

            // Push() --> adds elements to the top of the stack
            // Peek() --> reads the top element of the stack

            firstStack.Push(1);
            Console.WriteLine("Top value in the stack is {0}", firstStack.Peek());
            firstStack.Push(2);
            Console.WriteLine("Top value in the stack is {0}", firstStack.Peek());
            firstStack.Push(3);
            Console.WriteLine("Top value in the stack is {0}", firstStack.Peek());
            firstStack.Push(4);

            // Pop() --> removes the top element of  the estack, gives exception if there are no elements
            Console.WriteLine("Top value in the stack is {0}", firstStack.Peek());
            firstStack.Pop();
            Console.WriteLine("Top value in the stack is {0}", firstStack.Peek());

            //  loop to remove everything
            for (int i = firstStack.Count; i > 0; i--)
            {
                firstStack.Pop();
            }



            // reverse an array
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> reversedArray = new Stack<int>();

            // loop through the array
            Console.WriteLine("Array:");
            foreach (int el in numbers)
            {
                Console.Write("{0} ", el);
                reversedArray.Push(el);
            }


            Console.WriteLine("\nReversed array:");
            // print reversed array
            foreach (int el in reversedArray)
            {
                Console.Write("{0} ", el);
            }
        }
    }
}