using ObjectInitializers;

Console.WriteLine("***** Fun with Object Init Syntax *****\n");

// make a Point by setting each property manually
Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();

// make another Point using custom constructor
Point anotherPoint = new Point(20,20);
anotherPoint.DisplayStats();

// Os make a Point using object init syntax
Point finalPoint = new Point() { X = 30, Y = 30 };
finalPoint.DisplayStats();

Console.ReadLine();