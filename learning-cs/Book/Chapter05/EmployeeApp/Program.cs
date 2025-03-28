using EmployeeApp;
using static System.Console;

WriteLine("***** Fun with Encapsulation *****\n");

Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeeTypeEnum.Salaried);
WriteLine(emp.Pay);
emp.GiveBonus(100);
WriteLine(emp.Pay);

emp.DisplayStats();

// reset and then get the name property
emp.Name = "Marv";
WriteLine("Employee is named {0}", emp.Name);

Employee joe = new Employee("Joe", 456, 30000, "111-11-1111");
joe.Age++;
WriteLine("Joe age is {0}", joe.Age);

ReadLine();
