using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    public class University : Institute
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduleCourse { get; set; }
        public University(string name, int years)
        {
            ID = Guid.NewGuid();
            Name = name;
            YearsInService = years;
        }
        public Student[] GetStudents()
        {
            return Students;
        }
        public Course[] GetCourses()
        {
            return Courses;
        }
        public Grade[] GetGrades()
        {
            return Grades;  
        }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime)
        {

            
        }
       

    }
}
