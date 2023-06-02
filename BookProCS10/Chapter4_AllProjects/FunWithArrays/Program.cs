Console.WriteLine("***** Fun with Arrays *****");

SimpleArrays();

SimpleArraysCreation();

ArrayInitialization();

DeclareImplicirArrays();

ArrayOfObjects();

RectMultidimensionalArray();

JaggedMultidimensionalArray();

PassAndReceiveArrays();

SystemArrayFunctionality();

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
    foreach (int i in myInts)
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

    foreach (object obj in myObjects)
    {
        // print the type and value for each item
        Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
}

// multidimensional rectangular arrays
static void RectMultidimensionalArray()
{
    Console.WriteLine("=> Rectangular multidimensional array:");

    // a rectangular MD array
    int[,] myMatrix;

    myMatrix = new int[3, 4];
    /*
     {
        {1,2,3,4},
        {1,2,3,4},
        {1,2,3,4}
     }
     */

    int[,] myMatrixManual =
    {
        {1,2,3,4},
        {1,2,3,4},
        {1,2,3,4}
    };

    // Populate (3 * 4) araray
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }

    // print (3*4) array
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(myMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }


    // print manual array MD
    Console.WriteLine();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(myMatrixManual[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

/// jagged arrays
// contains inner arrays but each of them have different limit (not equals like rectangural arrays)
static void JaggedMultidimensionalArray()
{
    Console.WriteLine("=> Jagged multidimensional array:");

    // array of 5 different ways
    int[][] myJagArray = new int[5][];

    //create the jagged array
    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    // print each row (each element is defaulted to zero)
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// ARRAYS AS ARGUMENTS OR RETURN VALUES
static void PrintArray(int[] myInts)
{
    for (int i = 0; i < myInts.Length; i++)
    {
        Console.WriteLine("Item {0} is {1}", i, myInts[i]);
    }
    Console.WriteLine();
}

static string[] GetStringArray()
{
    string[] theStrings = { "Hello", "from", "GetStringArray" };
    return theStrings;
}

static void PassAndReceiveArrays()
{
    Console.WriteLine("=> Arrays as params and return values.");
    // pass array as parameter
    int[] ages = { 20, 22, 23, 0 };
    PrintArray(ages);

    // get array as return value
    string[] strs = GetStringArray();
    foreach (string s in strs)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine();
}

// --- USING THE SYSTEMARRAY CLASS ---
static void SystemArrayFunctionality()
{
    Console.WriteLine("=> Working with System.Array:");

    // initialize items at startup
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    // print out names in declared order
    Console.WriteLine("-> Here is the array:");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // print a name
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");

    // reverse them...
    Array.Reverse(gothicBands);
    Console.WriteLine("-> The reversed array");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // print a name
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");

    // clear out all but the first member
    Console.WriteLine("-> Cleared out all but one...");
    Array.Clear(gothicBands, 1, 2);
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // print a name
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");

    // USING INDICES AND RANGES
    gothicBands[0] = "Tones on Tail";
    gothicBands[1] = "Bauhaus";
    gothicBands[2] = "Sisters of Mercy";

    Console.WriteLine("-> Using 'index'");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        Index idx = i;
        //print a name
        Console.Write(gothicBands[idx] + ", ");
    }
    Console.WriteLine();

    for (int i = 1; i <= gothicBands.Length; i++)
    {
        Index idx = ^i;
        // ^ specify how many positions from the end of the sequence
        // if length is 10, ^1 is 9
        Console.Write(gothicBands[idx] + ", ");
    }
    Console.WriteLine("\n");

    Console.WriteLine("-> Range operator");
    // first is inclusive and last number exclusive
    // prints first two elements of the array
    foreach (string item in gothicBands[0..2])
    {
        //print name
        Console.Write(item + ", ");
    }
    Console.WriteLine("\n");

    Range r = 0..2;
    foreach (string item in gothicBands[r])
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine("\n");

    // defining ranges using index variables
    Index idx1 = 0;
    Index idx2 = 2;
    r = idx1..idx2;
    foreach (string item in gothicBands[r])
    {
        Console.Write(item + ", ");
    }
    Console.WriteLine("\n");

    Console.WriteLine("gothicBand[..]:");
    foreach(string item in gothicBands[..])
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("\ngothicBand[0..^0]:");
    foreach (string item in gothicBands[0..^0])
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("\ngothicBand[0..3]:");
    foreach (string item in gothicBands[0..3])
    {
        Console.Write(item + " ");
    }

    Console.WriteLine();
}