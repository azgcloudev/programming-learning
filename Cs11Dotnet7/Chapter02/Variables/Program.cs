using System.Xml;
using Variables;

// --- object type ---
object height = 1.88;
object name = "Aldair";
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length; // compile error as objecthas no Length  method
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");


// --- dynamic type ---
dynamic something = "anything";
//something = 1.33; // this will throw a exception as it has no Length property
something = new[] { 3, 5, 7 };

Console.WriteLine($"'something' length is {something.Length}");


// --- type inference using var ---
// numbers
var integerNumber = 1;
var doubleNumber = 1.33;
var floatNumber = 1.33F;
var decimalNumber = 4.5M;
var longNumbeer = 16666635667453466L;

// type usage
var xml1 = new XmlDocument(); // preferred as XmlDocument is clear the type and understandable
XmlDocument xm2 = new XmlDocument();

var file1 = File.CreateText("something1.txt"); // is not obviously clear the type, hence better to not use var
StreamWriter file2 = File.CreateText("something2.txt"); // preferred option

// --- targget type C#9.0+ ---
XmlDocument xml3 = new(); // no need write the class to intantiate
Person aldair = new();

List<Person> people = new()
{
    new() { FirstName = "Aldair"},
    new() { FirstName = "Antonio"}
};


//--- default values ---
Console.WriteLine();
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine("{0} value is {1}.", nameof(number), number);
number = default;
Console.WriteLine("{0} value is {1}.", nameof(number), number);

// end
Console.ReadKey();