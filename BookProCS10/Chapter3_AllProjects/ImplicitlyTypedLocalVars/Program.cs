Console.WriteLine("***** Fun with Implicit Typing *****");

DeclareImplicitVars();

DeclareImplicitNumerics();

Console.ReadLine();

static void DeclareImplicitVars()
{
    // implicit typed local variables
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";


    // print out the underlying type
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
    Console.WriteLine("myString is a: {0}", myString.GetType().Name);

    Console.WriteLine();
}


// DECLARE IMPLICIT NUMERICS
static void DeclareImplicitNumerics()
{
    // implicit typed numeric variables
    var myUInt = 0u;
    var myInt = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;

    // print out the underlying type
    Console.WriteLine("myUInt is a : {0}", myUInt.GetType().Name);
    Console.WriteLine("myInt is a : {0}", myInt.GetType().Name);
    Console.WriteLine("myLong is a : {0}", myLong.GetType().Name);
    Console.WriteLine("myDouble is a : {0}", myDouble.GetType().Name);
    Console.WriteLine("myFloat is a : {0}", myFloat.GetType().Name);
    Console.WriteLine("myDecimal is a : {0}", myDecimal.GetType().Name);

    Console.WriteLine();
}