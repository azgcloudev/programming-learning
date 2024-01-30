using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Length = length;
            Name = "Cube";
        }

        public override void GetInfo()
        {
            base.GetInfo(); // calls the GetInfo method from the base class
            Console.WriteLine($"The cube as a length of {Length}");
        }

        // to implement the method from the abstract class
        // need to use the 'override' keyword
        public override double Volume()
        {
            return Math.Pow(Length, 3);

        }
    }
}
