using System;
using System.Threading;

namespace MultiThreadedPrinting;

public class Printer
{
    public void PrintNumbers()
    {
        // display the thread info
        Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");
        
        // Print the numbers
        for (int i = 0; i < 10; i++)
        {
            Random r = new Random();
            Thread.Sleep(1000 * r.Next(5));
            Console.Write($"{i}, ");
        }

        Console.WriteLine();
    }
}