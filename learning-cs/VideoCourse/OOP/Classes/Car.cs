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
        private int _hp;
        private string? _color;
        private int _milesUsage;

        //==== Properties ======
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // auto implemented property
        /*
         * This are variables that will be created automatically once used
         * Do not required a field to bi initialized
         */
        public int MaxSpeed { get; set; }

        // read and write only properties
        // READONLY
        public string Year { get; } = "2020";

        // WRITEONLY       
        public int MilesUsage
        {
            set
            {
                _milesUsage = value; // this requires to create a private field
            }
        }

        // ======= end of properties =-========

        // getters and setters
        public void SetName(string name)
        {
            // set
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetHp()
        {
            return _hp;
        }

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
            _hp = int.Parse(hp);
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
