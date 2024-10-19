using System;
using System.Threading;

Console.WriteLine("***** Primary thread stats *****\n");

// obtain and name the current thread
Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "ThePrimaryThread";

// print out some stats
Console.WriteLine("ID of current thread: {0}", primaryThread.ManagedThreadId);
Console.WriteLine("Thread name: {0}", primaryThread.Name);