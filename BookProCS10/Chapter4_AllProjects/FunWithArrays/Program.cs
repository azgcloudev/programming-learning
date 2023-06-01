Console.WriteLine("***** Fun with Arrays *****");

SimpleArrays();

SimpleArraysCreation();

ArrayInitialization();

DeclareImplicirArrays();

ArrayOfObjects();

static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");
    // Create and fill an array of 3 integers
    int[] myInts = new int[3];
    //create a 100 item string array, indexed 0 -99
    string[] booksOnDotNet = new string[100];
    Console.WriteLine();
}

static void SimpleArraysCreation()
{
    Console.WriteLine("=> Simple Array Creation:");

    // create and fill an array of 3 integers
    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    // now print each value.
    foreach(int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}


// array initialization syntax
static void ArrayInitialization()
{
    Console.WriteLine("=> Array Initialization:");

    // array initialization syntax using the new keyword
    string[] stringArray = new string[] { "one", "two", "three" };
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);

    // array initialization without using the new keyword
    bool[] boolArray = { false, false, true };
    Console.WriteLine("boolArray has {0} elements", boolArray.Length);

    // array initialization with new keyword and size
    int[] intArray = new int[4] { 20, 22, 23, 0 };
    Console.WriteLine("intArray has {0} elements", intArray.Length);

    // size and elements quantity mismatch
    // int[] numbers = new int[3] { 1, 2 }; // compile error
    
    Console.WriteLine();
}

// implicitly typed local variables with arrays
static void DeclareImplicirArrays()
{
    Console.WriteLine("=> Implicit Array Initialization:");

    // a is really int[]
    var a = new int[] { 1, 10, 100, 1000 };
    Console.WriteLine("a is a: {0}", a.ToString());

    // b is really double[]
    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine("b is a: {0}", b.ToString());

    // c is really string[]
    var c = new[] { "hello", null, "world" };
    Console.WriteLine("c is a: {0}", c.ToString());

    Console.WriteLine();
}

// defining an array of objects
static void ArrayOfObjects()
{
    Console.WriteLine("=> Array of objects:");

    // an array of objects can be anything at all
    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void";

    foreach(object obj in myObjects)
    {
        // print the type and value for each item
        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
}