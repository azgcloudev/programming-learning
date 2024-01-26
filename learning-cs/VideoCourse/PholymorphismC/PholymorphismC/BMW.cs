
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PholymorphismC
{
    class BMW : Car
    {
        public string Model { get; set; }
        private string Brand = "Bmw";

        public BMW() { }

        public BMW(string color, int hp, string model) : base(color, hp)
        {
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The {Brand} {Model} has {HP}hp and is color {Color}");
        }

        // sealed prevents the method to be overriten by an sub-class
        // sealed needs to be typed before 'override'
        public sealed override void Repair()
        {
            Console.WriteLine($"{Brand} {Model} has been repaired");
        }
    }
}
