using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Car
    {
        // the state of the Car
        public string petName;
        public int currSpeed;

        // default constructor
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // constructor to define name, with default type value
        public Car(string pn)
        {
            petName = pn;
        }

        // functionality of the Car
        public void PrintState()
                => Console.WriteLine("{0} is going {1} MPH", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}
