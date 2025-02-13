namespace SimpleClassExample;

public class Motorcycle2
{
    public int driverIntinsity { get; set; }
    public string driverName { get; set; }

    public Motorcycle2(int intensity) : this(intensity, null)
    {
        Console.WriteLine("Constructor taking int");
    }

    public Motorcycle2(string name) : this(0, name)
    {
        Console.WriteLine("Constructor taking string");
    }

    public Motorcycle2(int intensity, string? name)
    {
        Console.WriteLine("Constructor main starting");
        if (intensity > 10)
        {
            driverIntinsity = intensity;
        }
    }
}