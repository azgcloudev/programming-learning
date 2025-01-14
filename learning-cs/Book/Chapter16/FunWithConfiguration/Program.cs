using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json",true,true)
    .AddJsonFile("appsettings.development.json", true,true)
    .Build();

Console.WriteLine($"My cars name is {config["CarName"]}");
Console.WriteLine($"CarName2 is null? {config["CarName2"] == null}");

// GetValue() method
Console.WriteLine("\nGetValue() method");
Console.WriteLine($"My car's name is {config.GetValue(typeof(string), "CarName")}");
Console.WriteLine($"My car's name is {config.GetValue<string>("CarName")}");

// GetValue() throws exception if data type casting is not possible
try
{
    Console.WriteLine($"My car's name is {config.GetValue<int>("CarName")}");
}
catch (Exception e)
{
    Console.WriteLine(e.GetBaseException().GetType());
    Console.WriteLine(e.Message);
}

// objects in config files
Console.WriteLine("\n*** Objects in config files ***");
Console.Write($"My car object is a {config["Car:Color"]} ");
Console.WriteLine($"{config["Car:Make"]} named {config["Car:PetName"]}");

// object using GetSection
IConfigurationSection section = config.GetSection("Car");
Console.WriteLine("Using GetSection() method:");
Console.Write($"My car object is a {section["Color"]} ");
Console.WriteLine($"{section["Make"]} named {section["PetName"]}");

// Bind method for non primitive instances
Console.WriteLine("\tUsing Bind() method:");
var c = new Car();
section.Bind(c);
Console.WriteLine($"My car is {c.Color} and is a {c.Make} named {c.PetName}");

// using the Get() method
Console.WriteLine(">> using Get() method:");
var carFromGet = config.GetSection(nameof(Car)).Get(typeof(Car)) as Car;
Console.WriteLine($"My car object using Get() is a {carFromGet.Color} {carFromGet.Make}");
Car? notFoundCarFromConfig = config.GetSection(nameof(Car)).Get(typeof(Car)) as Car; // If object is not found in config, returns null
Console.WriteLine($"Car from config is: {notFoundCarFromConfig == null} ");

public class Car
{
    public string Make { get; set; }
    public string Color { get; set; }
    public string PetName { get; set; }
}
