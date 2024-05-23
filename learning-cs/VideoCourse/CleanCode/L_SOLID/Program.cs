namespace L_SOLID;

class Program
{
    static void Main(string[] args)
    {
       /*
        * LISKOV SUSTITUTION PRINCIPLE
        * says that we should be able to replace our derive classes without the base class
        */
       Sparrow sparrow1 = new Sparrow();
       sparrow1.Fly();
       
       Bird sparrow = new Sparrow();
       ((IFlyable)sparrow).Fly(); // as it is created with Bird class, needs to cast the object with the Interface that inplements the method

       Bird penguin = new Penguin();
       penguin.MakeSound();

    }
}