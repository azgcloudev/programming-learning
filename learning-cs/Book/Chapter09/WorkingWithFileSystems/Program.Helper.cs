using System;

namespace WorkingWithFileSystems;

partial class Program
{
    public static void SectionTitle(string title)
    {
        WriteLine();
        ConsoleColor previousColor = ForegroundColor;

        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"*** {title} ***");
        ForegroundColor = previousColor;
    }
}