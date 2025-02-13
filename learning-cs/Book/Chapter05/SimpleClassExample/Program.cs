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

Console.ReadLine();