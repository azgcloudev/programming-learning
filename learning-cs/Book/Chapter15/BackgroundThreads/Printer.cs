using System;
using System.Threading;

namespace BackgroundThreads;

public class Printer
{
    public void PrintNumbers()
    {
        // display the thread info
        Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");
        
        // Print the numbers
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i}, ");
            Thread.Sleep(2000);
        }

        Console.WriteLine();
    }
}