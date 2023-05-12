Console.WriteLine("***** Fun with Conversions *****");

// add two shorts and print the result
short numb1 = 9, numb2 = 10;
// since short is shorter than Int, hence compiler winding automatilly short into
// int , because there won't be data loss
Console.WriteLine("{0} + {1}: {2}", numb1, numb2, Add(numb1, numb2));

// narrowing is the oposite of widening
// convert from bigger to smaller type

//// compile error
//numb1 = 30000;
//numb2 = 30000;
//short answer = Add(numb1, numb2);


//// another compile error
//static void NarrowingAttempt()
//{
//    byte myByte = 0;
//    int myInt = 200;
//    myByte = myInt;

//    Console.WriteLine("Value of myByte: {0}", myByte);
//}

// explicit cast of int into a short
// can ocurre data loss with explicit casting
short num1 = 30000, num2 = 30000;
short shortCasted = (short)Add(num1, num2);

Console.WriteLine("{0} + {1} = {2}",
    num1, num2, shortCasted);
NarrowingAttempt();

ProcessByte();

Console.ReadLine();

static int Add(int x, int y)
{
    return x + y;
}

static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    // explicit cast the int into byte (no loss of data)
    myByte = (byte)myInt;
    Console.WriteLine("Value of byte: {0}", myByte);

    Console.WriteLine();
}


// the checked keyword
static void ProcessByte()
{
    byte b1 = 100;
    byte b2 = 250;

    // tell the compiler to add CLI code
    // to throw an exception if overflow/underflow
    // takes place

    try
    {
        //byte sum = checked((byte)Add(b1, b2)); // using checked
        //Console.WriteLine("sum = {0}", sum);

        // can use also a block scope for checked
        checked
        {
            byte sum = (byte)Add(b1, b2);
            Console.WriteLine("sum = {0}", sum);
        }
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex);
    }

    Console.WriteLine();
}



// USE THE 'UNCHECKED' KEYWORD
// if project is enabled with checking for underflow/overflow
// unckecked allow data loss on a single statement (block, scopre)

