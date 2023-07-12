using static FunWithMethodOverloading.AddOperations;

Console.WriteLine("***** Fun with Method Overloading *****");

// Call int version of Add()
Console.WriteLine(Add(10, 10));

// Call long Add() version
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));

// Call double Add() version
Console.WriteLine(Add(4.3,  4.4));

// Null argument
EnterLogData(null, "Aldair");

Console.ReadLine();


// NULL ARGUMENT exepction
static void EnterLogData(string message, string owner = "Programmer")
{
    //if (message == null)
    //{
    //    throw new ArgumentNullException(message);
    //}

    //C# 10 new argument null exception syntax
    ArgumentNullException.ThrowIfNull(message);
    Console.WriteLine("Eror: {0}", message);
    Console.WriteLine("Ownerof error: {0}", owner);
}