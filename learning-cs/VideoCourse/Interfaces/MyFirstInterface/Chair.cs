using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstInterface
{
    class Chair : Furniture, IDestroyable
    {

        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            Color = color;
            Material = material;
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair destroyed");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts");
        }
    }
}
