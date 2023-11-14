namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // creating an object named audi, from the Car class
            Car audi = new Car("Audi", "350");

            Car bmw = new Car("BMW", "450");

            // using an object method
            audi.DrivingCar();
            bmw.DrivingCar();
            audi.Stop();
            bmw.Details();
        }
    }
}