using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius;
            Name = "Sphere";
        }

        public override double Volume()
        {
            return (4 / 3) * Radius * Math.PI;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"{Name} volume is {Volume()}");
        }
    }
}
