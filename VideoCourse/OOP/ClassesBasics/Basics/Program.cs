using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // instance of Human
            Human denis = new Human();

            denis.firstName = "Denis";  // access public variable from outside and change it
            denis.IntroduceMySelf();    // call method of an object

            Human michael = new Human();
            michael.IntroduceMySelf();
            michael.firstName = "Mikel";
            michael.IntroduceMySelf();

            Human aldair = new Human();
            aldair.firstName = "Aldair";
            aldair.lastName = "Zamora";

            Human joe = new Human();
            joe.firstName = "Joe";
            joe.lastName = "Doe";

            aldair.IntroduceMySelf();
            joe.IntroduceMySelf();

            Console.ReadKey();
        }
    }
}