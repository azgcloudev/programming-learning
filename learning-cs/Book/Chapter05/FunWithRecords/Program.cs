using FunWithRecords;

// using object initialization
Car myCar = new Car
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My Car: ");
DisplayCarStats(myCar);
Console.WriteLine();

//using custom constructor
Car anotherMyCar = new Car("Honda", "Pilot", "Black");
Console.WriteLine("Another variable of my car: ");
DisplayCarStats(anotherMyCar);
Console.WriteLine();

Console.WriteLine("******** RECORDS *************");
CarRecord myCarRecord = new CarRecord
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
Console.WriteLine();
CarRecord anotherCardRecord = new CarRecord("Honda", "Pilot", "Black");
Console.WriteLine("Another car record: ");
Console.WriteLine(anotherCardRecord.ToString());
Console.WriteLine();

Console.ReadLine();

static void DisplayCarStats(Car c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}

static void DisplayCarRecordStats(CarRecord c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}