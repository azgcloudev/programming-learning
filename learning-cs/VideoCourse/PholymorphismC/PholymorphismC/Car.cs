using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PholymorphismC
{
    class Car
    {
        public string Color { get; set; }
        public int HP { get; set; }

        public Car() { }
        public Car(string color, int hp)
        {
            Color = color;
            HP = hp;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Car color is '{Color}', HP is {HP}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
