namespace GenericsMultipleTypes
{
    public class Box<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public Box(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }

        public void Display()
    {
        Console.WriteLine($"First is {First} and Second is {Second}");
    }
    }
}