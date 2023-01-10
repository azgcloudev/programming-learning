using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // instance of Human
            Human denis = new Human("Denis", "Joe", 23, "green");

            denis.firstName = "Denis";  // access public variable from outside and change it
            denis.IntroduceMySelf();    // call method of an object

            Human michael = new Human("Mikel", "John", 45, "blue");
            michael.IntroduceMySelf();
    

            Human aldair = new Human("Aldair", "Zamora", 27, "brown");
            // aldair.LastName = "Gomez"; // since 'lastName' is private it cannot me access
            aldair.LastName("Gomez"); // it can be modified by creating a method

            Human joe = new Human("John", "Doe", 52, "black");

            aldair.IntroduceMySelf();
            joe.IntroduceMySelf();

            Console.ReadKey();
        }
    }
}