using System.Collections;

namespace IEnumerableAndIEnumeratorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (dog.IsNauthyDog == true)
                {
                    dog.GiveTreat(1);
                }
                else
                {
                    dog.GiveTreat(3);
                }
            }
        }
    }

    class Dog
    {
        // name
        public string Name { get; set; }

        // is nauthy?
        public bool IsNauthyDog { get; set; }


        // constructor
        public Dog(string name, bool isNauthyDog)
        {
            Name = name;
            IsNauthyDog = isNauthyDog;
        }

        // print how many threats the dog receives
        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine($"Dog: {Name} said wuoff {numberofTreats} times!.");
        }
    }

    class DogShelter : IEnumerable<Dog>
    {
        // list of Dogs
        public List<Dog> dogs;

        public DogShelter()
        {
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Zeus", false)
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
