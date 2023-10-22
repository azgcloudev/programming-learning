// when using topp level statements
// default namespace is Program
// Main method is created with the String array parameter

// Display message to the user
Console.WriteLine("***** My first C# app *****");
Console.WriteLine("Hello World");
Console.WriteLine();

// process incoming args
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("Args: {0}", args[i]);
}

// get CLI arguments from a method from System.Environment
string[] theArgs = Environment.GetCommandLineArgs();
foreach(string arg in theArgs)
{
    Console.WriteLine("Arg: {0}", arg);
}
Console.WriteLine();

ShowEnvironmentDetails();

// wait for ENTER key to be pressed before shutting down
Console.ReadKey();


static void ShowEnvironmentDetails()
{
    // print out the drives of the machine
    // and other interesting details
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }

    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}", Environment.Version);
}