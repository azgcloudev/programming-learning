using LambdaExpressions;

Console.WriteLine("***** Fun with Lambdas *****");

TraditionalDelegateSyntax();
AnonymousMethodSyntax();
LambdaExpressionSyntax();

// multiple parameter lambda expression
SimpleMath m = new SimpleMath();
m.SetMathHandler((msg, result) =>
{
    Console.WriteLine("Message: {0}, Result: {1}", msg, result);
});

m.Add(10,10);

// discards
var outerVariable = 0;
Func<int, int, bool> DoWork = (x, y) =>
{
    outerVariable++;
    return true;
};
DoWork(_, _); // discards can be minimum 2, can not be just 1 discard in the parameters
Console.WriteLine("Outer variable now is {0}", outerVariable);

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