using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            // add key values
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            // loop through the hashtable
            foreach (DictionaryEntry entry in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}.", entry.Key, entry.Value);
            }


            //creating a Hashtable using collection-initializer syntax
            Hashtable cities = new Hashtable()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            Console.WriteLine();
            foreach (DictionaryEntry entry in cities)
                Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);

            // challange
            /*
             * write a program that will iterate through each element of the students array and insert them into a hashtable.
             * if a student with the same ID already exists in the hashtable skip it and display the following error:
             * "Sorry, A student with the same ID already Exists".
             * Hist: Use the method ContainsKey() to check wether a student with the same ID already exist
            */

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsHash = new Hashtable();

            /*
            for (int i = 0; i < students.Length; i++)
            {
                if (studentsHash.ContainsKey(students[i].Id))
                {
                    Console.WriteLine("Sorry, A student with the same ID: {0} already Exists", students[i].Id);
                }
                else
                {
                    studentsHash.Add(students[i].Id, students[i]);
                    Console.WriteLine("Student with ID: {0} has been added", students[i].Id);
                }
            }
            */

            foreach (Student stu in students)
            {
                if (!studentsHash.ContainsKey(stu.Id))
                {
                    studentsHash.Add(stu.Id, stu);
                }
                else
                {
                    Console.WriteLine("Student with ID: {0} has been added", stu.Id);
                }
            }

            foreach (DictionaryEntry de in studentsHash)
            {
                Console.WriteLine("{0} : {1}", de.Key, de.Value);
            }

            Console.ReadKey();
        }
    }

    class Student
    {
        // property called ID
        public int Id { get; set; }

        // property called Name
        public string Name { get; set; }

        // property called GPA
        public float GPA { get; set; }

        // simple constructor
        public Student(int id, string name, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}