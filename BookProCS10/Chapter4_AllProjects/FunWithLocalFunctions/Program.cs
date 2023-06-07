
Console.WriteLine("AddWrapper: {0}", AddWrapper(4,6));

static int AddWrapper(int x, int y)
{
    return Add();

    int Add()
    {
        return x + y;
    }
}

// in c# 9.0 local functions
// allow attributes