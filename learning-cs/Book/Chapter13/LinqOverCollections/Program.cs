using System;
using System.Collections;
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
            LINQOverArrayList();
            OfTyoeAsFilter();

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

        static void LINQOverArrayList()
        {
            Console.WriteLine();
            Console.WriteLine("***** LINQ Over ArrayList *****");

            // non generic collection of cars
            ArrayList myCars = new ArrayList()
            {
                new Car { PetName = "Henry", Color = "Silver", Speed = 100, Make = "BMW" },
                new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car { PetName = "Mary", Color = "Black", Speed = 55, Make = "VW" },
                new Car { PetName = "Clunker", Color = "Rust", Speed = 5, Make = "Yugo" },
                new Car { PetName = "Melvin", Color = "White", Speed = 43, Make = "Ford" }
            };

            // Transform ArrayList into a compatible IEnumerable<T> type
            var myCarsEnum = myCars.OfType<Car>();

            // create a query expression targeting the compatible type
            var fastCars = from c in myCarsEnum where c.Speed > 55 select c;

            // displays each car
            foreach (var c in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", c.PetName);
            }
        }

        static void OfTyoeAsFilter()
        {
            // extract the ints from the ArrayList
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            var myInts = myStuff.OfType<int>();
            
            // print only 10,400,8
            foreach (var i in myInts)
            {
                Console.WriteLine("Int value: {0}", i);
            }
        }
    }
}