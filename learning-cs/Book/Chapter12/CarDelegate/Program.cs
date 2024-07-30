using System;
using CarDelegate;

Console.WriteLine("** Delegates as event enablers **\n");

// make the car object
var c1 = new Car("Slugbug", 100, 10);
var c2 = new Car();

// REGISTER MULTIPLE TARGET NOTIFICATIONS (MULTICASTING delegates)
// now, tell the car which method to call when it wants to send us a message
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);

c1.RegisterWithCarEngine(handler2);


// register a simple methof for c2 using 
// group conversion syntax
c2.RegisterWithCarEngine(OnCarEngineEvent);

// speed up (this will trigger events)
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 9; i++)
{
    c1.Accelerate(20);
}

// unregister c2 method
c2.UnRegisterWithCarEngine(OnCarEngineEvent);

// remove the upper case handler
c1.UnRegisterWithCarEngine(handler2);
Console.WriteLine("\n\n***** Speeding up *****");
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