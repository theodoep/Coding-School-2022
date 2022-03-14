using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityClassLibrary;

namespace UniversityForm
{
    public partial class CourseForm : Form
    {
        public Course CurrentCourse { get; set; }
        public CourseForm()
        {
            CurrentCourse = new Course();
            InitializeComponent();
        }

        private void ButtonCourseAdd_Click(object sender, EventArgs e)
        {
            CurrentCourse.Subject = Convert.ToString(textSubject.EditValue);
            CurrentCourse.Code = Convert.ToString(textCode.EditValue);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
