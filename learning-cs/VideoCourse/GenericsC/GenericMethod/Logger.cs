namespace GenericMethod
{
    public class Logger
    {
        // method with a geeneric type
        public void Log<T>(T message)
    {
        DateTime dateTime = new DateTime();
        Console.WriteLine($"[LOG] {dateTime} error: {message}");
    }
    }
}