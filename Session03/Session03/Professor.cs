using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03
{
    public class Professor : Person
    {
        public string Rank { get; set; }    
        public Course[] Courses { get; set; }
        public Professor(string name, int age, string rank)
        {
            ID = Guid.NewGuid();    
            Rank = rank;
            Name = name;
            Age = age;
            

        }
        public void Teach(Course course, DateTime datetime)
        {

        }
        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {

        }
        public string GetName()
        {
            return String.Format("Dr {0]", Name);
        }

    }
}
