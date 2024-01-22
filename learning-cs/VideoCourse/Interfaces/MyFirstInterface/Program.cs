namespace MyFirstInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two objects from Chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // new car object
            Car damagedCar = new Car(80F, "Blue");

            // Added the chairs to the destroyable nearby items
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
