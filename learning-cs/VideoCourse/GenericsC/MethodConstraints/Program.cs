namespace MethodConstraints;

class Program
{
    static void Main(string[] args)
    {
        Product first = new Product();
        Product second = new Product();

        bool result = Comparer.AreEqual(first, second);

        Console.WriteLine($"The object {first} and {second} are equal? {result}");
    }
}

internal class Product
{
}