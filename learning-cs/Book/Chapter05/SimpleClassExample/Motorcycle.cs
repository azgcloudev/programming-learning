namespace SimpleClassExample;

public class Motorcycle
{
    public int driverIntensity;
    public string name;
    
    public Motorcycle(int intensity)
    {
        driverIntensity = intensity;
    }

    public Motorcycle(string name) => this.name = name;
}