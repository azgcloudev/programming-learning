namespace VirtualOverrideDemo
{
    public class Dog : Animal
    {

        public bool IsHappy { get; set; }

        // constructor
        public Dog(string name, int age, bool isHungry) : base(name, age, isHungry)
        {
            IsHappy = true;
        }


        // override the empty Animal MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Wuuuuf!!");
        }


        // Call the original base method
        public override void Eat()
        {
            base.Eat();
        }

        // conditional method
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}