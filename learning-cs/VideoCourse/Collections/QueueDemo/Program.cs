using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();

            myQueue.Enqueue(1); // adds '1' to the end of the queue
            Console.WriteLine(myQueue.Peek()); //displays the top element in the queue

            myQueue.Enqueue(2);
            Console.WriteLine("Top value in queue is {0}", myQueue.Peek());

            myQueue.Enqueue(3);
            Console.WriteLine("Queue length is {0}", myQueue.Count);
            Console.WriteLine("Top value in queue is {0}", myQueue.Peek());
           
            while (myQueue.Count > 0)
            {
                Console.WriteLine("Removing {0} from queue.", myQueue.Dequeue()); // Dequeue returns and remove the top element in the queue
            }
             
            if (myQueue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
            }

            Console.ReadKey();
        }
    }
}