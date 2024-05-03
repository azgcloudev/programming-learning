using LINQToObjectsAndQueryOperators;

UniversityManager um = new UniversityManager();

um.MaleStudents();
um.FemaleStudents();
Console.WriteLine();
um.StudentsSortByAge();

Console.WriteLine();
um.AllStudentsFromBeijinTech();

Console.ReadKey();
