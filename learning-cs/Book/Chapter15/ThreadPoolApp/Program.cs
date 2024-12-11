using ThreadPoolApp;

Console.WriteLine("***** Fun with the .NET Core Runtime Thread Pool *****\n");

Console.WriteLine("Current main threaed running with id {0}", Environment.CurrentManagedThreadId);

Printer p = new Printer();

WaitCallback workitem = new(PrintTheNumbers);

// queue the method 10 times
for (int i = 0; i < 10; i++)
{
    ThreadPool.QueueUserWorkItem(workitem, p);
}

Console.WriteLine("All tasks queued");
Console.ReadLine();

static void PrintTheNumbers(object? state)
{
    Printer task = (Printer)state;
    task.PrintNumbers();
}