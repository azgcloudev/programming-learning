using AddWithThreads;

AutoResetEvent _waitHandle = new AutoResetEvent(false);

Console.WriteLine("***** Adding with Thread objects *****");
Console.WriteLine("ID of Main thread: {0}", Environment.CurrentManagedThreadId);

Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "Primary";

// invoke AddParams class
AddParams ap = new AddParams(10, 10);

Thread t = new Thread(new ParameterizedThreadStart(Add));
t.Start(ap);

// wait until other thread is completed
_waitHandle.WaitOne();

Console.WriteLine($"Thread {Thread.CurrentThread.Name} is done");
Console.ReadLine();

// add method 
void Add(object data)
{
    Thread currentThread = Thread.CurrentThread;
    currentThread.Name = "Secondary";
    Console.WriteLine($"Thread {currentThread.Name} started");
    
    if (data is AddParams ap)
    {
        Console.WriteLine($"ID of current thread in Add(): {currentThread.ManagedThreadId}");
        
        Console.WriteLine("{0} + {1} = {2}", ap.a, ap.b, ap.a + ap.b);
    }
    // tell the other thread this current thread is completed
    Console.WriteLine($"{currentThread.Name} is completed.");
    _waitHandle.Set();
}