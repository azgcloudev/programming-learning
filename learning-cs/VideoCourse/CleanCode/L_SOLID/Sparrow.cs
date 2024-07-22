namespace L_SOLID;

// Sparrow can fly, but not all birds can fly, hence to modify the Sparrow class without modifying the 
// Bird base class, will implement an interface in the sparrow class
public class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Flying");
    }
}