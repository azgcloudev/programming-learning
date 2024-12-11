using System;
using System.Threading;

namespace ThreadPoolApp;

public class Printer
{
    private object threadLock = new object();

    public void PrintNumbers()
    {
        Thread thread = Thread.CurrentThread;
        thread.Name = "Printing thread";
        
        // locking thread using System.Threading.Monitor
        Monitor.Enter(threadLock);
        try
        {
            // display the thread info
            Console.WriteLine($"-> {thread.Name}:id={thread.ManagedThreadId} is executing PrintNumbers()");

            // Print the numbers
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
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