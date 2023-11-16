namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // creating an object named audi, from the Car class
            Car audi = new Car("Audi", "350");

            Car bmw = new Car("Bmw", "450");

            // using an object method
            audi.DrivingCar();
            bmw.DrivingCar();
            audi.Stop();
            bmw.Details();

            Console.WriteLine(audi.GetHp());

            // Accesing properties
            Console.WriteLine("bmw name is: " + bmw.Name);
            bmw.Name = "BMW";
            Console.WriteLine("bmw name is: " + bmw.Name);

            Console.WriteLine("Max speed: {0}.", bmw.MaxSpeed);
            bmw.MaxSpeed = 100;
            Console.WriteLine("Max speed: {0}.", bmw.MaxSpeed);



        }
    }
}