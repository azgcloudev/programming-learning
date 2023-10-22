Console.WriteLine("***** Basic Console I/O *****");
// Get input and outputted it
GetUserData();

// numerical format specifiers
FormatNumericalData();

// using string.Format() to format string on other type of application
// such as ASP.NET  and desktop GUI apps
string userMessage = string.Format("100000 un hex is {0:X}", 100000);
Console.WriteLine(userMessage);

Console.ReadLine();

static void GetUserData()
{
    // get name and age
    Console.Write("Please enter your name: ");
    string userName = Console.ReadLine();
    Console.Write("Please enter your age: ");
    string userAge = Console.ReadLine();


    // display in the console
    Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
}

static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats:");
    int n = 99999;
    Console.WriteLine("c format: {0:c}", n);
    Console.WriteLine("d9 format: {0:d9}", n);
    Console.WriteLine("f3 format: {0:f3}", n);
    Console.WriteLine("n format: {0:n}", n);

    // notice that upper or lowercasing for Hex determines
    // if letters are upper or lower case
    Console.WriteLine("E format: {0:E}", n);
    Console.WriteLine("e format: {0:e}", n);
    Console.WriteLine("X format: {0:X}", n);
    Console.WriteLine("x format: {0:x}", n);
}