﻿Console.WriteLine("***** Generic Delegates *****\n");

// register targets
MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
strTarget("Some string data");

// using method group conversion syntax
MyGenericDelegate<int> intTarget = IntTarget;
intTarget(9);
Console.ReadLine();

static void StringTarget(string arg)
{
    Console.WriteLine("arg in uppercase is: {0}", arg.ToUpper());
}

static void IntTarget(int arg)
{
    Console.WriteLine("++arg is: {0}", ++arg);
}

// This generic delegate can represent any method
// returning void and taking a single parameter of type T
public delegate void MyGenericDelegate<T>(T arg);