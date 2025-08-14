using CallStackExceptionHandlingLib;
using static System.Console;

WriteLine("In Main");
Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Betha");
    try
    {
        Processor.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");
        throw;
    }
}