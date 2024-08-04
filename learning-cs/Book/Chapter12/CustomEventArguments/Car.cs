namespace CustomEventArguments;

public class Car
{
    private bool _carIsDead;
    
    // use the arguments of the object and the eventarg
    public delegate void CarEngineHandler(object sender, CarEventsArgs e);

    public int MaxSpeed { get; set; } = 100;
    public int CurrentSpeed { get; set; }
    public string Name { get; set; }
    
    // this car can send the events:
    public event CarEngineHandler Exploded;
    public event CarEngineHandler AboutToBlow;

    public Car()
    {
    }

    public Car(string name, int maxSpeed, int currentSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        CurrentSpeed = currentSpeed;
    }

    public void Accelerate(int delta)
    {
        // if the car is dead, fire the Exploded event
        if (_carIsDead)
        {
            Exploded?.Invoke(this, new CarEventsArgs("Sorry, this car is dead..."));
        }
        else
        {
            CurrentSpeed += delta;
            
            // almost dead?
            if (10 == MaxSpeed - CurrentSpeed)
            {
                AboutToBlow?.Invoke(this, new CarEventsArgs("Careful buddy! Gonna blow!"));
            }
            
            // still ok
            if (CurrentSpeed >= MaxSpeed)
            {
                _carIsDead = true;
            }
            else
            {
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}