WriteLine($"There are {args.Length} arguments");

// loop through arguments
foreach (string arg in args)
{
    WriteLine(arg);
}

// change foreground and background and cursor colors
if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, eg:");
    WriteLine("dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);
// cursor only works on windows
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("Changing the cursor size in this platform is not supported");
}

WriteLine("This text is from a different color");
// end
ReadKey();