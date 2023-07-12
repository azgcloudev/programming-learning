using static FunWithMethodOverloading.AddOperations;

Console.WriteLine("***** Fun with Method Overloading *****");

// Call int version of Add()
Console.WriteLine(Add(10, 10));

// Call long Add() version
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));

// Call double Add() version
Console.WriteLine(Add(4.3,  4.4));

Console.ReadLine();