using System;
using System.Collections.Generic;

namespace DictionariesCs
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] employees =
            {
                new Employee("CEO", "Halo", 90, 200),
                new Employee("Manager", "Pit", 35, 25),
                new Employee("HT", "Laura", 27, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Intern", "Lucio", 22, 12)
            };

            // declaring and initializing a dictionary
            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" }
            };

            // declare new dictionary
            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            // loop through the Employee object and add it to the dictionary
            foreach (Employee emp in employees)
            {
                employeeDirectory.Add(emp.Role, emp);
                Console.WriteLine($"{emp.Role} added successfully!.");
            }

            // print each employee
            foreach (KeyValuePair<string, Employee> emp in employeeDirectory)
            {
                Console.Write("\n");
                Console.WriteLine($"{emp.Key}:\nName - {emp.Value.Name}\nAge - {emp.Value.Age}\nSalary - {emp.Value.Salary}");
            }


            // update dictionary
            if (employeeDirectory.ContainsKey("CEO"))
            {
                employeeDirectory["CEO"] = new Employee("CEO", "Pat", 58, 300);
                Console.WriteLine("Employee {0} has been added with role {1}", employeeDirectory["CEO"].Name, employeeDirectory["CEO"].Role);
            }


            // remove dictionary
            string keyToRemove = "Intern";
            if (employeeDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("{0} was successfully removed.", keyToRemove);
            }

        }
    }

    class Employee
    {
        // properties
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        // simple constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}