
Console.WriteLine("AddWrapper: {0}", AddWrapper(4,6));

Console.WriteLine(AddWrapperWithSideEffect(5,5));

Console.WriteLine(AddWrapperWithStatic(10,10));

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

// STATIC LOCAL FUNCTIONS
static int AddWrapperWithSideEffect(int x , int y)
{
    return Add();

    int Add()
    {
        x += 1;
        return x + y;
    }
}

static int AddWrapperWithStatic(int x, int y)
{
    return Add(x,y);

    ////this will compile as static prevents from accessing parent  variables
    //// error CS8421: A static local function cannot contain a reference to 'x'.
    //static int Add()
    //{
    //    x += 1;
    //    return x + y;
    //}

    static int Add(int x, int y)
    {
        return x + y;
    }
}