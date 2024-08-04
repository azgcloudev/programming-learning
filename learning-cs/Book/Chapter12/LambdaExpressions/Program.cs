Console.WriteLine("***** Fun with Lambdas *****");

TraditionalDelegateSyntax();
AnonymousMethodSyntax();
LambdaExpressionSyntax();


Console.ReadLine();

static void TraditionalDelegateSyntax()
{
    // make a list of integers
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

    // call FindAll() using traditional delegate syntax
    Predicate<int> callback = IsEvenNumber;
    List<int> evenNumbers = list.FindAll(callback);

    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }

    Console.WriteLine();
}

void AnonymousMethodSyntax()
{
    // make a list of integers
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

    // use an anonymous method
    List<int> evenNumbers = list.FindAll(
        delegate(int i) { return (i % 2) == 0; });

    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }

    Console.WriteLine();
}

static void LambdaExpressionSyntax()
{
    // make a list of integers
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
    
    // use c# lambda expression
    List<int> evenNumbers = list.FindAll((i) =>
    {
        Console.WriteLine("value of i is currently: {0}", i);
        bool isEven = (i % 2) == 0;
        return isEven;
    });
    
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }

    Console.WriteLine();
}

// target for predicate delegate
static bool IsEvenNumber(int i)
{
    // is it even?
    return (i % 2) == 0;
}