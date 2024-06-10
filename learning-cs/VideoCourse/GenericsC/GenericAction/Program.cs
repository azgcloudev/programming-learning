namespace GenericAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action do not return anything
            // but it takes parameters
            Action action = () =>
            {
                Console.WriteLine("This print comes from the a Generic action<>");
            };

            Action<string> displayName = name =>
            {
                Console.WriteLine($"Hello {name} welcome to Generics");
            };

            action();
            displayName("Aldair");
        }
    }
}
