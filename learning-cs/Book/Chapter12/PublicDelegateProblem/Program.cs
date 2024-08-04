using PublicDelegateProblem;

Console.WriteLine("***** Agh! No Encapsulation! *****\n");

// make a car object
var myCar = new Car();

// direct access to the delegate
myCar.ListOfHandlers = CallWhenExploded;
myCar.Accelerate(10);

// now assign to a new whole object
myCar.ListOfHandlers = CallHereToo;
myCar.Accelerate(10);

// caller can directly invoke the delegate
myCar.ListOfHandlers.Invoke("hee, hee, hee...");
Console.ReadLine();

static void CallWhenExploded(string msg)
{
    Console.WriteLine(msg);
}

static void CallHereToo(string msg)
{
    Console.WriteLine(msg);
}