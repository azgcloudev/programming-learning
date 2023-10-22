try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine("Initial value: {0}", x);
        x++;
        WriteLine("After incrementing {0}", x);
        x++;
        WriteLine("After incrementing {0}", x);
        x++;
        WriteLine("After incrementing {0}", x);
    }
}
catch (OverflowException)
{
    WriteLine("Code overflowed.");
}