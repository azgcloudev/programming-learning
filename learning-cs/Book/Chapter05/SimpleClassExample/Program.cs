using SimpleClassExample;

Console.WriteLine("***** Fun with Class types *****\n");

// allo cate and  configura a Car
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

// speed up the car a few times and print out the 
// new state
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}

bool danger = false;
Car car2 = new Car("zeus", 101, out danger);
Console.WriteLine(danger);

Motorcycle myMotorcycle = new Motorcycle("Pancho");
Console.WriteLine($"Motorcycle name with parameter name and fiel name: '{myMotorcycle.name}'");

Motorcycle2 m2 = new Motorcycle2(1);
Console.WriteLine(m2.driverName);
Console.WriteLine(m2.driverIntinsity);

Console.ReadLine();