namespace CarWithLambda
{
    internal class Car
    {
        private bool _carIsDead;

        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int CurrentSpeed { get; set; }

        // this car can send the events:
        public event EventHandler<CarEventsWithLambdas> Exploded;
        public event EventHandler<CarEventsWithLambdas> AboutToBlow; 

        public Car() { }

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
                Exploded?.Invoke(this, new CarEventsWithLambdas("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;
            
                // almost dead?
                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke(this, new CarEventsWithLambdas("Careful buddy! Gonna blow!"));
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
}
