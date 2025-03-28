using AutoProps;

Console.WriteLine("***** Fun with Automatic Properties *****\n");

Car c = new Car();
c.PetName = "Frank";
c.Speed = 55;
c.Color = "Red";

Garage g = new Garage();
Console.WriteLine("Number of cars I have: {0}", g.NumerOfCars);
// Console.WriteLine(g.MyAuto.PetName); // this throws null exception

Console.ReadLine();