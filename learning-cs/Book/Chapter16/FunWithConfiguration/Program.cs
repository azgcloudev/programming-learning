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