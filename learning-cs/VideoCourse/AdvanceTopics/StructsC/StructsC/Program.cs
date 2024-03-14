namespace StructsC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STRUCTS
            Game game1;
            game1.Name = "Test";
            game1.Rating = 8.2;
            // game1.Display(); // cannot be used since not all the properties have a value yet
            game1.Force = 79;
            game1.Display();
        }

        private struct Game
        {
            public string Name;
            public int Force;
            public double Rating;

            public void Display()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Force: {Force}");
                Console.WriteLine($"Rating: {Rating}");
            }
        }
    }
}
