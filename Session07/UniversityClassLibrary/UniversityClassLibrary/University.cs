using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class University : Institute
    {
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduleCourse { get; set; }
        public List<Professor> Professors { get; set; }
        public University()
        {
            ID = Guid.NewGuid();
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduleCourse = new List<Schedule>();
            Professors = new List<Professor>();
        }
        public University(string name, int years)
        {
            ID = Guid.NewGuid();
            Name = name;
            YearsInService = years;
        }
        public List<Student> GetStudents()
        {
            return Students;
        }
        public List<Course> GetCourses()
        {
            return Courses;
        }
        public List<Grade> GetGrades()
        {
            return Grades;
        }
        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime)
        {


        }

    }
}
