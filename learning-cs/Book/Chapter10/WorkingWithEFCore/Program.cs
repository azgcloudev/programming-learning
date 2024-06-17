namespace WorkingWithEFCore;

class Program
{
    static void Main(string[] args)
    {
        using NorthwindDb db = new();
        WriteLine($"Provider: {db.Database.ProviderName}");
    }
}