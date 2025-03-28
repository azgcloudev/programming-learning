﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineStateEnum State { get; set; }
        public EngineStateEnum EngineState => State;
        public abstract void TurboBoost();

        protected Car(){ }
        protected Car(string name, int maxSpeed, int currentSpeed)
        {
            PetName = name;
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
        }
    }
}
