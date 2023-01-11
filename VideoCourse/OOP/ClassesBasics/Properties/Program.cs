using System;

namespace Properties;
class Program
{
    static void Main(string[] args)
    {
        
        Box box = new Box();
        // box.length = 3;  // length is private
        box.SetLength(5);
        Console.WriteLine("Box length is {0}:", box.GetLength());
        box.Width = 5;
        Console.WriteLine("The box volume is {0}", box.GetVolume());
        box.Height = -4;
        Console.WriteLine("Box height is: {0}", box.Height);
        Console.WriteLine("Box WidthProp: {0}", box.Width = 3);
        box.Volume = box.GetLength() * box.Width * box.Height;
        Console.WriteLine("Volume is {0}", box.Volume);
        
        Console.WriteLine("\n------------");
        Box newBox = new Box(3, 4, 5);
        newBox.DisplayInfo();
        newBox.Width = 10;
        newBox.DisplayInfo();

    }
}