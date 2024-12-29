Console.WriteLine("-> Having fun with ASYNC");
Console.WriteLine("Starting thread lock");
Console.WriteLine(DoWork());

Console.WriteLine("Start async");
string message = await DoWorkAsync();
Console.WriteLine(message);
try
{
    // async methods should be await in order to catch an exception
    await MethodReturningVoidAsync();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("Completed");

Console.ReadLine();

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