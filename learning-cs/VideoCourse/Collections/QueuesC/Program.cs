// initialize a queue
Queue<int> queue1 = new Queue<int>();

// add items to the queue
queue1.Enqueue(1);
queue1.Enqueue(2);
queue1.Enqueue(23);

// Get the first item in the queue
Console.WriteLine(queue1.Peek());

// Remove the first item in the queue
int current = queue1.Dequeue();
Console.WriteLine(current);
current = queue1.Dequeue();
Console.WriteLine(current);

// if the queue is empty and try to Dequeue it will throw an exception
// so should check before deuqueuing
if (queue1.Count > 0)
{
    queue1.Dequeue();
}