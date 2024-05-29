namespace GenericsConstraints
{
    class Program
    {
        static void Main(string[] args)
    {
        // Constraints sets conditions 
        Box<Book> bookBox = new Box<Book>();

        // Box<int> intBox = new Box<int>(); // this is not allowed because of the constraint.
    }
    }

    class Book
    {
    }
}