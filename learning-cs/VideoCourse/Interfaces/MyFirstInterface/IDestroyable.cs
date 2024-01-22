using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstInterface
{
    interface IDestroyable
    {
        // property to store the destruction sound file
        string DestructionSound { get; set; }

        // method that will destroy the object
        void Destroy();
    }
}