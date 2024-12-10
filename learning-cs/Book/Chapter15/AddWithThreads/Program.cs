using AddWithThreads;

Console.WriteLine("***** Adding with Thread objects *****");
Console.WriteLine("ID of Main thread: {0}", Environment.CurrentManagedThreadId);

// invoke AddParams class
AddParams ap = new AddParams(10, 10);

Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);

Console.ReadLine();

// add method 
void Add(object data)
{
    if (data is AddParams ap)
    {
        Console.WriteLine($"ID of current thread in Add(): {Environment.CurrentManagedThreadId}");
        
        Console.WriteLine("{0} + {1} = {2}", ap.a, ap.b, ap.a + ap.b);
    }
}