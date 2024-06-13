namespace ThreadsDemo;

class Program
{
    static void Main(string[] args)
    {
        // the following runs in the single MAIN thread
        /*
        Console.WriteLine("Hello 1");
        Thread.Sleep(2000);
        Console.WriteLine("Hello 2");
        Thread.Sleep(2000);
        Console.WriteLine("Hello 3");
        Thread.Sleep(2000);
        Console.WriteLine("Hello 4");
        */

        // running multiple threads
        // they will run at the same time, not necessary in the same order
        new Thread(() =>
        {
            Console.WriteLine("Thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 1 ended");
        }).Start();
        new Thread(() =>
        {
            Console.WriteLine("Thread 2");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 2 ended");
        }).Start();
        new Thread(() =>
        {
            Console.WriteLine("Thread 3");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 3 ended");
        }).Start();
        new Thread(() =>
        {
            Console.WriteLine("Thread 4");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 4 ended");
        }).Start();

        Console.ReadKey();
    }
}