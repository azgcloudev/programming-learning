using System.Numerics; // namespace to use BigIntegers

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

        useDateAndTimes();

        UseDatesAndTimes();

        UseBigInteger();

        DigitSeparators();

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



    // System.DateTime and System.TimeSpan
    static void useDateAndTimes()
    {
        Console.WriteLine("=> Dates and Times:");

        // constructor takes year, month and date
        DateTime dt = new DateTime(2015, 10, 17);

        // what day of the month is this?
        Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

        // Month is now December
        dt = dt.AddMonths(2);
        Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

        // this constructor takes hours, minutes and seconds
        TimeSpan ts = new TimeSpan(4, 30, 0);
        Console.WriteLine(ts);

        // Subtract 15 min from currect timespan and
        // print the results
        Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

        Console.WriteLine();
    }


    // new to .net6 - date only and time only
    // aligns to the SQL server date and time types
    static void UseDatesAndTimes()
    {
        Console.WriteLine("=> Dates and Times:");

        DateOnly d = new DateOnly(2021, 06, 21);
        Console.WriteLine(d);

        TimeOnly t = new TimeOnly(13, 30, 0, 0);
        Console.WriteLine(t);

        Console.WriteLine();
    }


    // using BigIntegers
    static void UseBigInteger()
    {
        BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
        Console.WriteLine("Value of biggy is {0}", biggy);
        Console.WriteLine("Is biggy an even value: {0}", biggy.IsEven);
        Console.WriteLine("Is biggy a power of two: {0}", biggy.IsPowerOfTwo);
        BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("123456789098765432123456789098765432345678909876"));
        Console.WriteLine("Value of reallyBig is {0}", reallyBig);
        //using c# mathematical operators
        BigInteger reallyBig2 = biggy * reallyBig;
        Console.WriteLine("Value of reallyBig2 is {0}", reallyBig2);
        Console.WriteLine();
    }



    // digit separators from c# 7.0
    static void DigitSeparators()
    {
        Console.WriteLine("=> Use digit separators");
        Console.Write("Integer:");
        Console.WriteLine(123_456);
        Console.Write("Long:");
        Console.WriteLine(123_456_789L);
        Console.Write("Hex:");
        Console.WriteLine(0x_00_00_FF);
        Console.WriteLine();
    }

}