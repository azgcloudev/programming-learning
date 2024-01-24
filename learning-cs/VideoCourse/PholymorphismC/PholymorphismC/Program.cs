using System;
using System.Collections.Generic;

namespace PholymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Blue", 90),
                new BMW("black", 400, "m2"),
                new Audi("White", 389, "R8")
            };

            foreach (var car in cars)
            {
                car.Repair();
                // show details wont call the class showdetails method
                // instead will use the Car showdetails, even if the 'new' keyword is used
                // cars is from class Car.
                // Only objects as class BMW or Audio will call its method. The only way to override it is using the 
                // virtual and override keyword
                car.ShowDetails();
            }
        }
    }
}
