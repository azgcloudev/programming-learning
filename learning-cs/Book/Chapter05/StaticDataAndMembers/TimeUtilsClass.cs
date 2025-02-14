namespace StaticDataAndMembers;

public class TimeUtilsClass
{
    public static void PrintTime()
        => Console.WriteLine(DateTime.Now.ToShortTimeString());

    public static void PrintDate()
        => Console.WriteLine(DateTime.Now.ToShortDateString());
}