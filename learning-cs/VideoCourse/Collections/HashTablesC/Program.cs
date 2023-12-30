using System.Collections;
using HashTablesC;

/*
 * Hash tables are key-value 
 */

// create a new hashtable
Hashtable studentsTable = new Hashtable();

Student stud1 = new(1, "Juan", 4.34);
Student stud2 = new(2, "Carlos", 3.53);
Student stud3 = new(3, "Pedro", 7.23);
Student stud4 = new(4, "Luis", 9.12);

// add elements to the hashtable
studentsTable.Add(stud1.Id, stud1);
studentsTable.Add(stud2.Id, stud2);
studentsTable.Add(stud3.Id, stud3);
studentsTable.Add(stud4.Id, stud4);

// get a value from a hash table. Individual item.
Student storedStudent1 = (Student)studentsTable[1]; // object needs to be cast to the Student type

// retrive all values from a hashtable
foreach (DictionaryEntry entry in studentsTable)
{
    Student temp = (Student)entry.Value;
    Console.WriteLine(temp.Name);
    Console.WriteLine(temp.Id);
    Console.WriteLine(temp.GPA);
}

foreach (Student value in studentsTable.Values)
{
    Console.WriteLine(value.Name);
    Console.WriteLine(value.Id);
    Console.WriteLine(value.GPA);
}


/***********************************************
 * CHALLANGE
 * *********************************************/
Student[] students = new Student[5];
students[0] = new Student(1, "Denis", 88);
students[1] = new Student(2, "Olaf", 97);
students[2] = new Student(6, "Ragner",65);
students[3] = new Student(1, "Luise", 73);
students[4] = new Student(4, "Levi", 58);

/*
 * Loop the array and add each student into a hashtable.
 * If the ID is already in the hashtable display error: "Sorry, A student with the same ID already exists"
 */
Hashtable theStudents = new Hashtable();
foreach (Student value in students)
{
    if (theStudents.ContainsKey(value.Id))
    {
        Console.WriteLine("Sorry, A student with the same ID already exists");
    }
    else
    {
        theStudents.Add(value.Id, value);
    }
}