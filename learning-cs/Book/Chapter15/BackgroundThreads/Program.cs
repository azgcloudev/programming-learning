namespace BackgroundThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Background Threads *****\n");

            Printer p = new Printer();

            Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));

            // set the thread as background
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }
    }
}
