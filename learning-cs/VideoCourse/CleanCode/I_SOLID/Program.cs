namespace I_SOLID;

class Program
{
    // INTERFACE SEGREGATION PRINCIPAL
    /*
     * Interfaces should be split if they get to big and classes
     * are not implementing all of its methods
     */
    static void Main(string[] args)
    {
        Robot robot = new Robot();
        robot.Work();
    }
}

// WHAT NOT TO DO
/*
public interface IWorker
{
    void Work();
    void Eat();
}

public class Worker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot working");
    }

    public void Eat()
    {
        // robots do not eat but IWorker interface forces to add the method
        throw new NotImplementedException();
    }
}
*/



/// INSTEAD CREATE METHODS IN DIFFERENT INTERFACES
public interface IEatable
{
    void Eat();
}

public interface IWorkable
{
    void Work();
}

public class Worker : IWorkable, IEatable
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

public class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Working");
    }
}
