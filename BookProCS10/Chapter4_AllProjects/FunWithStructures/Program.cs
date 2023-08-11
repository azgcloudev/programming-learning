// Create an initial Point
Point myPoint;
myPoint.X = 350;
myPoint.Y = 730;
myPoint.Display();
myPoint.Decrement();
myPoint.Display();

// default values using constructor new
Point p1 = new Point();
p1.Display();
p1.Increment();
p1.Display();

// structure declaration with custom constructor
Point p2 = new Point(10, 20);
p2.Display();


// end
Console.ReadLine();

struct Point
{
    // fields
    // c#10+ fields can be initialize
    public int X = 10;
    public int Y = 542;

    // parameterless constructor
    public Point() { }

    // custom constructor
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

    // methods
    public void Increment()
    {
        X++;
        Y++;
    }

    public void Decrement()
    {
        X--;
        Y--;
    }


    // displays the current position
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

readonly struct ReadOnlyStruct
{
    // fields
    public int X { get; }
    public int Y { get; }

    // display current position
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

    // constructor
    public ReadOnlyStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
}