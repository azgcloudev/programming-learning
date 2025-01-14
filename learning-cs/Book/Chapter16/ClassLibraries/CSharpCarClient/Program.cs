using CarLibrary;

Console.WriteLine("***** C# CarLibrary Client App *****");

// make sports car
SportsCar viper = new SportsCar("Viper", 240,50);
viper.TurboBoost();

// make mini van
MiniVan mv = new MiniVan();
mv.TurboBoost();

Console.WriteLine("Done. Press any key to terminate");
Console.ReadKey();