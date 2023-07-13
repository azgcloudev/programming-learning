Console.WriteLine("***** Fun with Enums *****");

// Enum type variable
EmpTypeEnum em = EmpTypeEnum.Contractor;
AskForBonus(em);

// Enum System.Enum class
// get underlying type
Console.WriteLine($"EmpTypeEnum uses a \"{Enum.GetUnderlyingType(em.GetType())}\" for storage");
Console.WriteLine("EmpTypeEnum uses a \"{0}\" for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));

// get enum name in string and get the value
Console.WriteLine("\nem is {0}", em.ToString());
Console.WriteLine("{0} value is {1}", em.ToString(), (byte)em);

// Enum printing details
Console.WriteLine();
EvaluateEnum(em);

Console.ReadLine();

// local functions
static void AskForBonus(EmpTypeEnum e)
{
    switch (e)
    {
        case EmpTypeEnum.Manager:
            Console.WriteLine("How about stock options instead?");
            break;
        case EmpTypeEnum.Grunt:
            Console.WriteLine("You have got to be kidding...");
            break;
        case EmpTypeEnum.Contractor:
            Console.WriteLine("You already get enough cash");
            break;
        case EmpTypeEnum.VicePresident:
            Console.WriteLine("VERY GOOD, SIR");
            break;
    }
}

// method will print details out of any enum
static void EvaluateEnum(System.Enum e)
{
    Console.WriteLine("=> Information about {0}", e.GetType().Name);

    Console.WriteLine("Underlyting storage type {0}", Enum.GetUnderlyingType(e.GetType()));

    // get all name value pairs for incoming parameters
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members", enumData.Length);

    // Show the string name and associated value, using D format
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}",enumData.GetValue(i));    
    }

}

// Custom enumeration
enum EmpTypeEnum
{
    Manager,        // = 0
    Grunt,          // = 1
    Contractor,     // = 2
    VicePresident   // = 3
}

// enum custom enumeration start number
enum EmpTypeNumberedEnum
{
    Manager = 102,
    Grunt,          // = 103
    Contractor,     // = 104
    VicePresident,  // = 105
}

// element in enum need not to be sequential
// change enum storage default type (System.Int32) to a byte
enum EmpTypeNonSequentialEnum : byte
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 9
}