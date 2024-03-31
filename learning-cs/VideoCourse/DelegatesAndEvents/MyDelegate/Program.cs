namespace MyDelegate
{
    internal class Program
    {
        // Defining a delegate type called FilterDelegate that takes a person object
        // and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // create 4 person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

            // ANONYMOUS METHOD
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };
            DisplayPeople("Kids", people, filter);

            DisplayPeople("All", people, delegate (Person p) { return true; }); // anonymous method passed as argument

            // LAMDA STATEMENT
            // syntax: (parameters) => { expression }
            string searchKeyword = "a";
            DisplayPeople("age > 20 with seach keyword " + searchKeyword, people, p =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }

                return false;
            });

            // lamda expression
            // SYNTAX: (parameters) => expression // expression is in a single line
            DisplayPeople("Exactly 25", people, p => p.Age == 25);
        }

        public static void DisplayPeople(string title, List<Person> list, FilterDelegate filter)
        {
            Console.WriteLine($"{title}:");

            foreach (Person p in list)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
            Console.WriteLine();
        }

        // ================ FILTERS =======================
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
