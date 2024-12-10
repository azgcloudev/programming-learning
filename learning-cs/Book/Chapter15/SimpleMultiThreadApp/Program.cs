using System;
using System.Threading;

namespace SimpleMultiThreadApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** The Amazing Thread App *****\n");
        Console.Write("Do you want [1] or [2] thread?: ");
        string userInput = Console.ReadLine()!;

        int threadQuantity;
        int.TryParse(userInput, out threadQuantity);

        if (int.TryParse(userInput, out threadQuantity) is false)
        {
            return;
        }

        // Name the Thread
        Thread currentThread = Thread.CurrentThread;
        currentThread.Name = "Primary";

        // display Primary thread info
        Console.WriteLine($"-> {currentThread.Name} is running Main()");

        // create the Printer class
        Printer p = new Printer();

        if (threadQuantity == 1)
        {
            p.PrintNumbers();
        }
        else
        {
            // make a new thread
            Thread backGroundThread = new Thread(new ThreadStart(p.PrintNumbers));
            backGroundThread.Name = "Secondary";
            backGroundThread.Start();
        }

        // Do aditional work
        Console.WriteLine("This is on the main thread and we are finished.");
        Console.Write("Touch any key to exit: ");
        Console.ReadLine();
    }
}