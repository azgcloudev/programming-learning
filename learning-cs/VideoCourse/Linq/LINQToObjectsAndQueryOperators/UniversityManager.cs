using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    internal class UniversityManager
    {
        List<Student> students;
        List<University> universities;

        // constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Add universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijin Tech" });

            // Add students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 6, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "male"
                                                select student;

            Console.WriteLine("Male students:");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            var femaleStudents = from student in students where student.Gender == "female" select student;

            Console.WriteLine("Female students");
            foreach (var student in femaleStudents)
            {
                student.Print();
            }
        }
    }
}
