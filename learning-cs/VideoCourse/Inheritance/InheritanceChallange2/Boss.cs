namespace InheritanceChallange2
{
    class Boss : Employee
    {
        // fields
        public bool CompanyCar { get; set; }

        // constructor
        public Boss() { }
        public Boss(bool companyCar)
        {
            CompanyCar = companyCar;
        }

        public Boss(string name, string firstName, double salary, bool companyCar) : base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        // methods
        public void Lead()
        {
            Console.WriteLine("I am the Boss and I am leading all the projects.");
        }
    }
}
