namespace GenericsMultipleTypes
{
    class Program
    {
        static void Main(string[] args)
    {
        Box<int, string> box = new Box<int, string>(21, "June");
        
        box.Display();
    }
    }
}