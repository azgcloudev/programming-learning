using System;
using System.Threading;

Console.WriteLine("***** Primary thread stats *****\n");

// obtain and name the current thread
Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "ThePrimaryThread";

// print out some stats
Console.WriteLine("ID of current thread: {0}", primaryThread.ManagedThreadId);
Console.WriteLine("Thread name: {0}", primaryThread.Name);
Console.WriteLine("Has thread started?: {0}", primaryThread.IsAlive);
// update priority from ENUM ThreadPriority
primaryThread.Priority = ThreadPriority.AboveNormal;
Console.WriteLine("Priority Level: {0}", primaryThread.Priority);
Console.WriteLine("Thread State: {0}", primaryThread.ThreadState);
Console.ReadKey();

