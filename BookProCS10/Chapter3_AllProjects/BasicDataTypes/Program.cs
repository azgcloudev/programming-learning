using System.Numerics;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Basic Data Types *****");

        LocalVarDeclarations();

        defaultDeclarations();

        newingDataTypes();

        newingDataTypesWith9();

        objectFunctionality();

        dataTypeFunctionality();

        charFunctionality();

        parseFromString();

        parseFromStringUsingTryParse();

        Console.ReadKey();
    }

    static void LocalVarDeclarations()
    {
        Console.WriteLine("=> Declarations:");
        // local variables are declared as so:
        // datatype varName =  initial value;
        int myInt = 0;

        // can declare and assign on two lines
        string myString;
        myString = "This is my character data";

        // declare multiple variables in single line
        // of the same type
        bool b1 = true, b2 = false, b3 = true;

        // Using System.Boolean data type do declare a bool
        System.Boolean b4 = false;

        Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

        Console.WriteLine();
    }

    // default keyboard
    static void defaultDeclarations()
    {
        Console.WriteLine("=> Default declarations:");
        int myInt = default;
        Console.WriteLine(myInt);
    }


    // declaring variables using 'new' keywword
    static void newingDataTypes()
    {
        Console.WriteLine("=> Using new to create variables");
        // new creates the variables using default construct
        // they are created with its  default value
        bool b = new bool(); // false
        int i = new int();  // 0
        double d = new double();    // 0
        DateTime dt = new DateTime();   // 1/1/0001 12:00:00 AM
        Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
        Console.WriteLine();
    }

    // new variable declaration with new in c#9
    static void newingDataTypesWith9()
    {
        Console.WriteLine("=> Using new to create variables");
        bool b = new(); // false
        int i = new();  // 0
        double d = new();    // 0
        DateTime dt = new();   // 1/1/0001 12:00:00 AM
        Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
        Console.WriteLine();
    }

    // System.Object functionality
    static void objectFunctionality()
    {
        Console.WriteLine("=> System.Object functionality:");

        // c# int is a short hand for System.Int32
        // which inherit the following members from System.Object
        Console.WriteLine("12.GetHashCode = {0}", 12.GetHashCode());
        Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
        Console.WriteLine("12.ToString() = {0}", 12.ToString().GetType());
        Console.WriteLine("12.GetType() = {0}", 12.GetType());
        Console.WriteLine();
    }


    // Members of numerical data types
    static void dataTypeFunctionality()
    {
        Console.WriteLine("Max of int is {0}", int.MaxValue);
        Console.WriteLine("Min of int is {0}", int.MinValue);
        Console.WriteLine("Max of double is {0}", double.MaxValue);
        Console.WriteLine("Min of double is {0}", double.MinValue);
        Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
        Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
        Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
        Console.WriteLine();
    }


    // Members of System.Char
    static void charFunctionality()
    {
        Console.WriteLine("=> char type functionality:");
        char myChar = 'a';
        Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
        Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
        Console.WriteLine("char.IsWhiteSpace('Hello there', 5): {0}", char.IsWhiteSpace("Hello there", 5));
        Console.WriteLine("char.IsWhiteSpace('Hello there', 6): {0}", char.IsWhiteSpace("Hello there", 6));
        Console.WriteLine("char.IsPunctuation('?')", char.IsPunctuation('?'));
        Console.WriteLine();
    }


    // Parsing values from string data
    static void parseFromString()
    {
        Console.WriteLine("=> Data type parsing:");
        bool b = bool.Parse("True");
        Console.WriteLine("Value of b: {0}", b);
        double d = double.Parse("99.884");
        Console.WriteLine("Value of d: {0}", d);
        int i = int.Parse("8");
        Console.WriteLine("Value of i: {0}", i);
        char c = Char.Parse("H");
        Console.WriteLine("Value of c: {0}", c);
        Console.WriteLine();
    }


    // parsing from string using tryparse
    static void parseFromStringUsingTryParse()
    {
        Console.WriteLine("=> Data type parsing with TryParse:");
        // tryparse returns a boolean
        if (bool.TryParse("True", out bool b))
        {
            Console.WriteLine("Value of b: {0}", b);
        }
        else
        {
            Console.WriteLine("Default value of b: {0}", b);
        }

        string value = "hello";
        if (double.TryParse(value, out double d))
        {
            Console.WriteLine("Value of d: {0}", d);
        }
        else
        {
            Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned to the default {1}",
                value, d);
        }

        Console.WriteLine();
    }
}