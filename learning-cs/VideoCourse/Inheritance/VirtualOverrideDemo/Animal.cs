namespace VirtualOverrideDemo
{
    public class Animal
    {
        // properties
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        // constructor
        public Animal(string name, int age, bool isHungry)
        {
            Name = name;
            Age = age;
            IsHungry = isHungry;
        }


        // method

        // virtual keyword allows an inherited class to implement the same method from the parent class
        public virtual void MakeSound() { }

        // a virtual method not necessary needs to be empty, and can be override with the
        // override keyboard from the inherited class
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
            }
            else
            {
                Console.WriteLine($"{Name} is not eating.");
            }
        }
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }
}