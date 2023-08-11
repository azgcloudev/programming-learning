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



// end
Console.ReadLine();

struct Point
{
    // fields
    public int X;
    public int Y;

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