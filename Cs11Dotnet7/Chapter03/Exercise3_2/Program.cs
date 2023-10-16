int max = 500;

try
{

    checked
    {
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    }
}
catch (OverflowException)
{
    WriteLine("Overflow, number is greater or lower its maximum value type.");
}

// what will happen if the code executes?
// i will overflow and loop forever as never reach 500

// add code to fix the issue, by not changing curent code
// - added checked
// - put checked in try catch