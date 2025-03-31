namespace AutoProps;

public class Garage
{
    // default value to zero
    public int NumerOfCars { get; set; } = 1;
    
    // default value to null
    public Car MyAuto { get; set; } = new Car();
    
    public Garage()
    {
    }

    public Garage(int numberOfCars, Car car)
    {
        NumerOfCars = numberOfCars;
        MyAuto = car;
    }
}