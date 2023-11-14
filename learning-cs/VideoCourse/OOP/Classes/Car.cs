using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
    {
        // fields to store data (variables)
        private string? _name;
        private string? _hp;
        private string? _color;

        // default constructor
        public Car() { }

        // constructors
        public Car(string name)
        {
            _name = name;
        }

        public Car(string name, string hp = "0", string color = "white") // name = value, defines the default value if not provided
        {
            _name = name;
            _hp = hp;
            _color = color;
        }

        // methods
        public void DrivingCar()
        {
            Console.WriteLine("{0} is driving.", _name);
        }

        public void Stop()
        {
            Console.WriteLine("{0} stopped.", _name);
        }

        public void Details()
        {
            Console.WriteLine($"{_name} has {_hp} horsepower.");
        }
    }
}
