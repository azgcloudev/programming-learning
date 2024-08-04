using System.Security.Cryptography;
using CustomEventArguments;

var c1 = new Car("SlugBug", 100, 10);

// register the event handlers
c1.Exploded += CarAboutToBlow;
c1.AboutToBlow += CarIsAlmostDoomed;

Car.CarEngineHandler d = CarExploded;
c1.Exploded += d;

Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
    


static void CarAboutToBlow(object sender, CarEventsArgs e)
{
    Console.WriteLine(e.msg);
}

static void CarIsAlmostDoomed(object sender, CarEventsArgs e)
{
    Console.WriteLine(e.msg);
}

static void CarExploded(object sender, CarEventsArgs e)
{
    if (sender is Car c)
    {
        Console.WriteLine($"Critical message from {c.Name}: {e.msg}");
    }
}