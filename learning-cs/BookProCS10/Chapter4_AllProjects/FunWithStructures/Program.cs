Console.WriteLine("***** A first look at structures *****\n");

// create an initial Point
Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();

// adjust the X and Y values
myPoint.Increment();
myPoint.Display();


// create struct with default constructor, and set variables to its default value
Console.WriteLine("\n\nDefault construct");
Point defaultPoint = new Point();
defaultPoint.Display();


// create struct with customer construct
Console.WriteLine("\n\n___ Custom constructor ___");
Point p2 = new Point(50, 60);
p2.Display();

// creating a readonly struct
Console.WriteLine("\n\n__Readonly struct___");
ReadOnlyPoint p3 = new ReadOnlyPoint(100, 200);
p3.Display();


// readonly members
Console.WriteLine("\n\n___Readonly members___");
PointWithReadOnly p4 = new PointWithReadOnly(20, 34, "Point w/RO");
p4.Display();

// end
Console.ReadLine();


// =================================================

// first struct
struct Point
{
    // fields of the struct
    public int X;
    public int Y;

    // custom constructor
    public Point(int yPos, int xPos)
    {
        Y = yPos;
        X = xPos;
    }

    // Add 1 to the X Y position
    public void Increment()
    {
        X++; Y++;
    }

    // substract 1 from X, Y position
    public void Decrement()
    {
        X--; Y--;
    }

    // display the current position
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}


// structures needs to use all variables in it, otherwise will get a compile error.


// read only struct
readonly struct ReadOnlyPoint
{
    // fields
    public int X { get; }
    public int Y { get; }

    // display current point
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }

}


// readonly members
public struct PointWithReadOnly
{
    // fields
    public int X;
    public readonly int Y;
    public readonly string Name;

    // methods
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}, Name = {2}", X, Y, Name);
    }

    // custom constructor
    public PointWithReadOnly(int yPos, int xPos, string namePos)
    {
        Y = yPos;
        X = xPos;
        Name = namePos;
    }
}