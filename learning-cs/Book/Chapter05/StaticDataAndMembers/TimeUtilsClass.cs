using static System.Console; // static import
using static System.DateTime;

namespace StaticDataAndMembers;

public class TimeUtilsClass
{
    public static void PrintTime()
        => WriteLine(Now.ToShortTimeString());

    public static void PrintDate()
        => WriteLine(Now.ToShortDateString());
}