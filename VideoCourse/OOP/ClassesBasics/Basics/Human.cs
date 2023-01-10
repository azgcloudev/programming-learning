using System;

namespace Basics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        public string firstName; // need public to be added to be access from a different file
        private string lastName = "Doe";
        private int age;
        private string eyeColor;


        // constructor
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName; // this call the class firstName variable
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        // member method
        public void IntroduceMySelf()
        {
            Console.WriteLine("Hi, I'm {0} {1} my eyes are {2} and I am {3} years old", firstName, lastName, eyeColor, age);
        }

        // method use to modify the object lastname
        public void LastName(string lastName)
        {
            this.lastName = lastName;
        }
    }
}
