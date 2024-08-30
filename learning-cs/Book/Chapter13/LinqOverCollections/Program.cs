using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over Generic Collections *****\n");

            // List of Car objects
            List<Car> myCars = new List<Car>()
            {
                new Car { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
                new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
                new Car { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
                new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            };

            GetFastCars(myCars);
            GetFastBMWs(myCars);

            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            // Find all Car objects in the List<>, where the Speed is
            // greater than 55.
            var subset = from car in myCars where car.Speed > 55 select car;

            // print the name of the petname from the subset
            foreach (var car in subset)
            {
                Console.WriteLine($"{car.PetName} is going too fast!");
            }
        }

        /// <summary>
        /// Get only BMWs cars going over 55 speed, from a List.
        /// </summary>
        /// <param name="myCars"></param>
        static void GetFastBMWs(List<Car> myCars)
        {
            var subset = from c in myCars
                where c.Speed > 55 && c.Make.ToLower() == "bmw"
                select c;

            // displays the cars
            foreach (var car in subset)
            {
                Console.WriteLine("{0} is going too fast", car.PetName);
            }
        }
    }
}