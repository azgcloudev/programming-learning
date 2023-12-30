//==================
//STACKS
//==================

// stacks add elemets to the front and takes them from the front

Stack<int> stack = new Stack<int>();

// add items to the stack
stack.Push(1);
stack.Push(2);

// get the value from the top item
Console.WriteLine(stack.Peek());

// remove the top element and it returns the value of the element removed
// if there are no elements to remove it will get an exception InvalidOperationException
int removed = stack.Pop();
Console.WriteLine($"Elemented removed was {removed}");
Console.WriteLine($"Top element is {stack.Peek()}");

// loop thru the stack
Console.WriteLine("\n\n--- Stack loop ---");
stack.Push(100);
stack.Push(30);
stack.Push(23);
stack.Push(43);
stack.Push(34);
stack.Push(544);
stack.Push(23);
stack.Push(6567);

while ( stack.Count > 0 )
{
    int value = stack.Pop();
    Console.WriteLine($"Pop {value}");
}


// reverse and array
Console.WriteLine("\n\n--- Reverse an array ---");
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] reversedNumbers = new int[numbers.Length];
Stack<int> temp = new Stack<int>();
foreach (int num in numbers)
{
    temp.Push(num);
}
for (int i = 0; i < numbers.Length; i++)
{
    int n = temp.Pop();
    reversedNumbers[i] = n;
}


foreach(int n in numbers)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
foreach (int n in reversedNumbers)
{
    Console.Write($"{n} ");
}

//==================
//QUEUES
//==================