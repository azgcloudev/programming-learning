using System;

namespace MultipleConstructors;

class Program
{
    static void Main(string[] args)
    {
        Human antonio = new Human();

        Human aldair = new Human("Aldair", "Zamora", "Brown");
        Human bastian = new Human("Bastian", "Zamora", "Brown", 5);
        Human connie = new Human("Connie", "Anchia");

        aldair.IntroduceSelf();
        bastian.IntroduceSelf();
        connie.IntroduceSelf();
    }
}
