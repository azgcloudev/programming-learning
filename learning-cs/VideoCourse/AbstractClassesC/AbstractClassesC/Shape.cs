using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesC
{
    // abstract classes cannot be use to create new objects
    abstract class Shape
    {

        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("This is a {0}", Name);
        }

        // abstract  method to implement in the classes inherited from an abstract clas
        public abstract double Volume();
    }
}
