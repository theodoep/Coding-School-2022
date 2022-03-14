using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using UniversityClassLibrary;
using System.IO;

namespace UniversityForm
{
    public partial class UniversityForm : Form
    {
        public University CurrentUniversity { get; set; }
        public UniversityForm()
        {
            InitializeComponent();
            CurrentUniversity = new University();
        }


        private void buttonAddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StudentAddForm studentAddForm = new StudentAddForm();
            studentAddForm.ShowDialog();

            if (studentAddForm.DialogResult == DialogResult.OK)
            {
                AddStudenttoUni(studentAddForm.CurrentStudent);
            }
        }
        public void AddStudenttoUni(Student student)
        {
            CurrentUniversity.Students.Add(student);

            listBoxStudents.Items.Clear();
            listBoxStudents.DataSource = CurrentUniversity.Students.Select(s => s.Name);
        }

        private void ButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string jsonStr = JsonSerializer.Serialize(CurrentUniversity);
            string fileName = "uni.json";
            File.WriteAllText(fileName, jsonStr);

        }

        private void Load_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string fileName = "uni.json";
            string jsonStr = File.ReadAllText(fileName);
            CurrentUniversity = JsonSerializer.Deserialize<University>(jsonStr);
            
            LoadListBoxData();
        }


        private void LoadListBoxData()
        {
            listBoxStudents.DataSource = CurrentUniversity.Students.Select(stu => stu.Name);
            listBoxProfessors.DataSource = CurrentUniversity.Professors.Select(prof => prof.Name);
            listBoxCourses.DataSource = CurrentUniversity.Courses.Select(cour => cour.Subject);
        }

        private void buttonAddProfessor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProfessorAddForm professorAddForm = new ProfessorAddForm();
            professorAddForm.ShowDialog();  
            if (professorAddForm.DialogResult == DialogResult.OK)
            {
                AddProfessortoUni(professorAddForm.CurrentProfessor);
            }
        }
        public void AddProfessortoUni(Professor professor)
        {
            CurrentUniversity.Professors.Add(professor);

            listBoxProfessors.Items.Clear();
            listBoxProfessors.DataSource = CurrentUniversity.Professors.Select(prof => prof.Name);
        }

        private void buttonAddCourse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.ShowDialog();

            if (courseForm.DialogResult == DialogResult.OK)
            {
                AddCourse(courseForm.CurrentCourse);
            }
        }
        public void AddCourse(Course course)
        {
            CurrentUniversity.Courses.Add(course);

            listBoxCourses.Items.Clear();
            listBoxCourses.DataSource = CurrentUniversity.Courses.Select(cour => cour.Subject);
        }
    }
}
