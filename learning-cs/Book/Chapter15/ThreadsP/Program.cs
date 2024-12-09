ExtractExecutingThread();
ExtractAppDomainHostingThread();

Console.ReadKey();

/// Get the current thread for the method
static void ExtractExecutingThread()
{
    Thread currThread = Thread.CurrentThread;
    Console.WriteLine("Current thread ID: {0}", currThread.ManagedThreadId);
}

/// Get the AppDomain of the current thread
static void ExtractAppDomainHostingThread()
{
    AppDomain ad = Thread.GetDomain();
    Console.WriteLine("Current thread AppDomain: {0}", ad.FriendlyName);
}

// obtein the execution context of the current thread
static void ExtractCurrentThreadExecutionContext()
{
    ExecutionContext? ctx = Thread.CurrentThread.ExecutionContext;
}