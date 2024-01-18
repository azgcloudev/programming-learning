namespace InheritanceChallange2
{
    class Employee
    {
        // fields
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public double Salary { get; set; }


        // constructor
        public Employee() { }
        public Employee(string name, string firstName, double salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        // methods
        public virtual void Work() { }
        public void Pause() 
        {
            Console.WriteLine("I am taking a quick pause.");
        }

    }
}
