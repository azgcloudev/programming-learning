namespace TimerApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Working with Timer type *****\n");

        // create delegate
        TimerCallback timerCB = new TimerCallback(PrintTime);

        // timer settings
        Timer _ = new Timer(
            timerCB, // delegate
            "<TIME> =>", // info to pass in the called method
            0, // time to wait before starting
            1000 // interval in miliseconds
        );
    
        Console.WriteLine("Enter key to terminate...");
        Console.ReadLine();
    }

    static void PrintTime(object? state)
    {
        Console.WriteLine($"{state.ToString()} Current time is {DateTime.Now.ToLongTimeString()}");
    }
}