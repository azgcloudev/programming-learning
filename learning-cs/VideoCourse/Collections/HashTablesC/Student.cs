﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesC
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student(int id, string name, double gpa)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
