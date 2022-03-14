using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClassLibrary
{
    public class Grade
    {
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int NumGrade { get; set; }
        public Grade()
        {
            ID = Guid.NewGuid();
        }
        public Grade(Guid studentID, Guid courseID, int grade)
        {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            NumGrade = grade;

        }
    }
}
