using System;

namespace Challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4);
            Console.WriteLine("The frontsurface is {0}", box.FrontSurface);
        }
    }
}