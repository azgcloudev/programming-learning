using System;
using System.Threading;

namespace MultiThreadedPrinting;

public class Printer
{
    private object threadLock = new object();

    public void PrintNumbers()
    {
        /***** lock using lock keyword
         *
        // lock thread
        lock (threadLock)
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
        */

        // locking thread using System.Threading.Monitor
        Monitor.Enter(threadLock);
        try
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
        finally
        {
            Monitor.Exit(threadLock);
        }
    }
}