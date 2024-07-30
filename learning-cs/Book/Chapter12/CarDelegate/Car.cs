using System;

namespace CarDelegate
{
    internal class Car
    {
        // internal state data
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
        
        // is the car alive or dead
        private bool _carIsDead;


        // Class instructors
        public Car()
        {
        }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // 1) define the delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        // 2) Define a member value for the delegate
        private CarEngineHandler _listOfHandlers;

        // 3) Add registration function for the caller
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            //_listOfHandlers = methodToCall; // add a single method

            // multicasting to append multiple methods
            _listOfHandlers += methodToCall;
        }

        // remove delegates
        public void UnRegisterWithCarEngine(CarEngineHandler methodCall)
        {
            _listOfHandlers -= methodCall;
        }

        // 4) Implement the Accelerate() method to invoke the delegate's invocation list
        // under the correct circumstances
        public void Accelerate(int delta)
        {
            // if car is dead, send dead message
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                // is the car almost dead?
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
                }

                if (CurrentSpeed > MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
