using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstInterface
{
    class Car : Vehicle, IDestroyable
    {

        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            Speed = speed;
            Color = color;
            DestructionSound = "CarExplosionSound.mp3";

            // Initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }

        // Destroy method
        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            // go thru each destroyable items nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
