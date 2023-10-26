Console.WriteLine("***** A first look at structures *****\n");

// create an initial Point
Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();

// adjust the X and Y values
myPoint.Increment();
myPoint.Display();
Console.ReadLine();



// =================================================

// first struct
struct Point
{
    // fields of the struct
    public int X;
    public int Y;

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