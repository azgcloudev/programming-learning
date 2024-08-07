﻿using AnonymousMethods;

Console.WriteLine("***** Anonymous Methods *****\n");
int aboutToBlowCounter = 0;

var c1 = new Car("Slugbug", 100, 10);

// register event handlers as anonymous methods
c1.AboutToBlow += delegate
{
    aboutToBlowCounter++;
    Console.WriteLine("Eek! Going too fast!");
};

c1.AboutToBlow += delegate(object sender, CarEventsArgs e)
{
    aboutToBlowCounter++;
    Console.WriteLine("Message from Car: {0}", e.msg);
};

c1.Exploded += delegate(object sender, CarEventsArgs e)
{
    Console.WriteLine("Fatal Message from Car: {0}", e.msg);
};

// this will eventually trigger the events
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}

Console.WriteLine("AboutToBlow even was fired {0} times", aboutToBlowCounter);
Console.ReadLine();