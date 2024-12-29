Console.WriteLine("-> Having fun with ASYNC");
//Console.WriteLine("Starting thread lock");
//Console.WriteLine(DoWork());

//Console.WriteLine("Start async");
// string message = await DoWorkAsync();
// Console.WriteLine(message);
// try
// {
    // async methods should be await in order to catch an exception
    // await MethodReturningVoidAsync();
// }
// catch (Exception e)
// {
    // Console.WriteLine(e.Message);
// }

// await MultipleAwaits();
// await MultipleAwaitAsync();

// await MultipleAwaitWhenAnyAsync();

// Console.WriteLine("Completed");

static string DoWork()
{
    Thread.Sleep(5000);
    return "DoWork is completed";
}

static async Task<string> DoWorkAsync()
{
    return await Task.Run(() =>
    {
        Thread.Sleep(5000);
        return "Done the work";
    });
}


//// async void methods
static async Task MethodReturningVoidAsync() // void async methods should be Task and not void
{
    await Task.Run(() =>
    {
        Thread.Sleep(5000);
        throw new Exception("Method returning void");
    });
    Console.WriteLine("MethodReturningVoidAsync is completed");
}


//// multiple awaits in an async method
static async Task MultipleAwaits()
{
    // this task are processed in order of sleep from low to max
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("First task completed");
    });
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Second task completed");
    });
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
        Console.WriteLine("Third task completed");
    });
}

// multiple operations in a single await
static async Task MultipleAwaitAsync()
{
    await Task.WhenAll(
        Task.Run(() =>
        {
            Thread.Sleep(2000);
            Console.WriteLine("1st task completed");
        }),
        Task.Run(() =>
        {
            Thread.Sleep(3000);
            Console.WriteLine("2nd task completed");
        }),
        Task.Run(() =>
        {
            Thread.Sleep(1000);
            Console.WriteLine("3rd task completed");
        }));
}

//await returns the first Task completed
static async Task MultipleAwaitWhenAnyAsync()
{
    await Task.WhenAny(Task.Run(() =>
    {
        var r = new Random();
        int n = r.Next(0, 4000);
        Thread.Sleep(n);
        Console.WriteLine("1st task completed");
    }), Task.Run(() =>
    {
        var r = new Random();
        int n = r.Next(0, 4000);
        Thread.Sleep(n);
        Console.WriteLine("2nd task completed");
    }), Task.Run(() =>
    {
        var r = new Random();
        int n = r.Next(0, 4000);
        Thread.Sleep(n);
        Console.WriteLine("3rd task completed");
    }));
}


// --> Await in catch and finally Blocks
static async Task<string> MethodWithTryCatch()
{
    try
    {
        // do something
        return "Hello";
    }
    catch (Exception ex)
    {
        await LogErrors();

        async Task LogErrors()
        {
            throw new NotImplementedException();
        }

        throw;
    }
    finally
    {
        await DoMagicCleanUp();

        async Task DoMagicCleanUp()
        {
            throw new NotImplementedException();
        }
    }
}

