using System;

namespace MultipleConstructors
{
    public class Human
    {
        private string? firstName;
        private string? lastName;
        private string? eyeColor;
        private int age;


        public Human()
        {
            Console.WriteLine("Constructor initialized");
        }


        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        // constructor with no age
        public Human(string firstName, string lastName, string eyeColor) // eye will be 0
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }


        // member method
        public void IntroduceSelf()
        {
            if (eyeColor == null && age == 0)
            {
                Console.WriteLine("I'm {0} {1}", firstName, lastName);
            }
            else if (age == 0)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstName, lastName, eyeColor);
            }
            else
            {
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
            }
        }

    }
}