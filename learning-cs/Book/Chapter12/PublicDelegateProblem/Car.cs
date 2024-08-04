namespace PublicDelegateProblem;

public class Car
{
    public delegate void CarEngineHandler(string msgForCaller);
    
    // a public member
    public CarEngineHandler ListOfHandlers;
    
    // fire out the exploded notification
    public void Accelerate(int delta)
    {
        if (ListOfHandlers != null)
        {
            ListOfHandlers("Sorry, this car is dead...");
        }
    }
}