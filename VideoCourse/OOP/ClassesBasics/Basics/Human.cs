using System;

namespace Basics
{
    // this class is a blueprint for a datatype
    class Human
    {
        // member variable
        public string firstName = "Michael"; // need public to be added to be access from a different file
        public string lastName = "Hook";

        // member method
        public void IntroduceMySelf()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
