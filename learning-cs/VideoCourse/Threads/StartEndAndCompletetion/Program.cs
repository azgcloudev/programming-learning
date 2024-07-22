using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StartEndAndCompletetion;

class Program
{
    static void Main(string[] args)
    {
        // this case will run forever as the taskCompletionSource is false and will not continue in the current thread
        // holding the whole application
        /*
        TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();

        bool test = taskCompletionSource.Task.Result;
        */
        
        
        
        
        // expected behavior using a thread
        /*
        TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();

        var thread = new Thread(() =>
        {
            // shows current thread id
            Console.WriteLine("Thread number: {0}", Thread.CurrentThread.ManagedThreadId);
            
            // wait before changing the task status
            Thread.Sleep(3000);
            taskCompletionSource.TrySetResult(true);
            Console.WriteLine("Thread {0} finished", Thread.CurrentThread.ManagedThreadId);
        });
        
        // start the thread before the task is ran
        thread.Start();
        
        bool test = taskCompletionSource.Task.Result;
        */


        // ====== THREAD POOL ===========
        // background threads
        // manage threads when there is availability
        Enumerable.Range(0, 50).ToList().ForEach(f =>
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine("Thread number {0} started", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);

                Console.WriteLine("Thread number {0} end", Thread.CurrentThread.ManagedThreadId);
            });
        });

        Console.ReadLine();
    }
}