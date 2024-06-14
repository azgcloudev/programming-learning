using System;
using System.Threading;

namespace JoiningAndIsAlive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");

            // Join holds the parent thread until the caller thread is finished
            Thread thread1 = new Thread(ThreadFunction1);
            Thread thread2 = new Thread(ThreadFunction2);

            thread1.Start();
            thread2.Start();

            // check if thread finished before X seconds
            if (thread1.Join(1000))
            {
                Console.WriteLine("Thread 1 finished in 2 seconds.");
            }
            else
            {
                Console.WriteLine("Thread 1 was not finished in 2 seconds");
            }

            thread2.Join();
            // thread1.Join();
            
            
            
            
            
            Console.WriteLine("Main thread ended");

            // Console.ReadKey();
        }

        public static void ThreadFunction1()
        {
            Console.WriteLine("Thread 1 started");
            Thread.Sleep(4000);
            Console.WriteLine("Thread 1 ended");
        }

        public static void ThreadFunction2()
        {
            Console.WriteLine("Thread 2 started");
            Thread.Sleep(6000);
            Console.WriteLine("Thread 2 ended");
        }
    }
}
