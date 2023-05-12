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