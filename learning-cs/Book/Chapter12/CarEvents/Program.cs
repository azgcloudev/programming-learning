using CarEvents;
/*
// syntax:
// NameOfObject.NameOfEvent += new RelatedDelegate(functionCall)
Car.CarEngineHandler d = new Car.CarEngineHandler(CarExplodedEventHandler);

var myCar = new Car();
myCar.Exploded += d;
*/

Console.WriteLine("***** Fun with Events *****\n");
var c1 = new Car("SlugBug", 100, 10);

// register event handlers
c1.AboutToBlow += CarIsAlmostDoomed;
c1.Exploded += CarAboutToBlow;

Car.CarEngineHandler d = CarExploded;
c1.Exploded += d;

Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

// remove car exploded method
c1.Exploded -= d;

Console.WriteLine("\n***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

Console.ReadLine();


static void CarIsAlmostDoomed(string msg)
{
    Console.WriteLine("=> Critical message from Car: {0}", msg);
}

static void CarExploded(string msg)
{
    Console.WriteLine(msg);
}

static void CarAboutToBlow(string msg)
{
    Console.WriteLine(msg);
}