using EmployeeApp;
using static System.Console;

WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new Employee("Marvin", 456, 30000);
emp.GiveBonus(1000);
emp.DisplayStats();

// reset and then get the name property
emp.Name = "Marv";
WriteLine("Employee is named {0}", emp.Name);

Employee joe = new Employee("Joe", 456, 30000);
joe.Age++;
WriteLine("Joe age is {0}", joe.Age);

ReadLine();
