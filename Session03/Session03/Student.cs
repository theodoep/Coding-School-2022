﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public Course[] Courses { get; set; }
        public Student()
        {
            ID = Guid.NewGuid();
        }
        public Student(int regNumber, string name, int age)
        {
            RegistrationNumber = regNumber;
            Name = name;    
            Age = age;
            ID = Guid.NewGuid();
        }
        public void Attend(Course course, DateTime datetime)
        {

        }
        public void WriteExam(Course course, DateTime datetime)
        {

        }

    }
}
