namespace InheritanceChallange2
{
    class Trainee : Employee
    {
        // fields
        public int WorkHours { get; set; }
        public int SchoolHours { get; set; }

        // constructor
        public Trainee() { }
        public Trainee(int workHours, int schoolHours)
        {
            WorkHours = workHours;
            SchoolHours = schoolHours;
        }
        public Trainee(string name, string firstName, double salary) : base(name, firstName, salary) { }
        public Trainee(string name, string firstName, double salary, int schoolHours, int workHours) : base(name, firstName, salary)
        {
            SchoolHours = schoolHours;
            WorkHours = workHours;
        }


        // methods
        public override void Work()
        {
            Console.WriteLine($"Trainee salary is {WorkHours * Salary}.");
        }

        public void Learn()
        {
            Console.WriteLine("As a trainee I am learning new things.");
        }
    }
}
