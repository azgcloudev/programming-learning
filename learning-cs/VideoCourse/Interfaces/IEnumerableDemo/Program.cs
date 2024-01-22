namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable to store the INumerable
            // IEnumerable can hold any type of collection like Array, Queue, List, because they Inherit
            // the IEnumerable interfaces
            IEnumerable<int> unknownCollection;

            unknownCollection = GetCollection(4);

            // array
            Console.WriteLine("Collection of array");
            foreach(int i in unknownCollection)
            {
                Console.Write(i + " ");
            }

            // Queue
            Console.WriteLine("/nCollection of queue");
            unknownCollection = GetCollection(2);
            foreach(int i in unknownCollection )
            {
                Console.Write(i + " ");
            }

        }


        static IEnumerable<int> GetCollection(int n)
        {
            if (n == 4)
            {
                // array
                return new int[] { 1, 2, 3, 4, 5 };
            }
            else if (n == 1)
            {
                // List
                List<int> l = new List<int> { 5, 6, 7, 8 };
                return l;
            }
            else if (n == 2)
            {
                // queue
                Queue<int> myQueue = new Queue<int>();
                myQueue.Enqueue(5);
                myQueue.Enqueue(19);
                myQueue.Enqueue(20);
                myQueue.Enqueue(30);
                myQueue.Enqueue(100);

                return myQueue;
            }
            else
            {
                return new int[] { };
            }
        }
    }
}
