using System;
using CarDelegate;

Console.WriteLine("** Delegates as event enablers **\n");

// make the car object
var c1 = new Car("Slugbug", 100, 10);

// REGISTER MULTIPLE TARGET NOTIFICATIONS (MULTICASTING delegates)
// now, tell the car which method to call when it wants to send us a message
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

// speed up (this will trigger events)
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 9; i++)
{
    c1.Accelerate(20);
}
Console.ReadLine();

// this is the target for incoming events
static void OnCarEngineEvent(string msg)
{
    Console.WriteLine("\n*** Message from Car object ***");
    Console.WriteLine("=> {0}", msg);
    Console.WriteLine("********************\n");
}

// second event
static void OnCarEngineEvent2(string msg)
{
    Console.WriteLine("--> {0}", msg.ToUpper());
}