using Microsoft.Extensions.Configuration;

IConfiguration config = new  ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json",true,true)
    .Build();

Console.WriteLine($"My cars name is {config["CarName"]}");