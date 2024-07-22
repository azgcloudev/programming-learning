namespace IntroToGenerics
{
    class Program
    {
        static void Main(string[] args)
    {
        List<string> books = new List<string>();
        
        Box<int> boxInt = new Box<int>();
        boxInt.Content = 2;

        Box<string> boxStr = new Box<string>();
        boxStr.Content = "Regalos";

        Console.WriteLine(boxInt.Log());
        Console.WriteLine(boxStr.Log());

        Bag<string> bag = new Bag<string>("Pali");
        bag.UpdateContent("Walmart");
        Console.WriteLine(bag.GetContent());
    }
    }
}