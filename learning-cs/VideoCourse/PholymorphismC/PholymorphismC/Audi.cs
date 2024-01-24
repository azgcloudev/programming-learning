using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PholymorphismC
{
    class Audi : Car
    {
        public string Model { get; set; }
        private string Brand = "Audi";

        public Audi() { }
        public Audi(string color, int hp, string model) : base(color, hp)
        {
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"The {Brand} {Model} has {HP}hp and is color {Color}");
        }

        public override void Repair()
        {
            Console.WriteLine($"{Brand} has been repaired");
        }
    }
}
