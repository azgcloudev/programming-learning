using AutoProps;

Console.WriteLine("***** Fun with Automatic Properties *****\n");

Car c = new Car();
c.PetName = "Frank";
c.Speed = 55;
c.Color = "Red";

Garage g = new Garage();
Console.WriteLine("Number of cars I have: {0}", g.NumerOfCars);
Console.WriteLine($"My car name is {g.MyAuto.PetName}");
g.MyAuto.PetName = "Franky";
Console.WriteLine($"My car name is {g.MyAuto.PetName}");

Console.ReadLine();