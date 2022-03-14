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
    public partial class StudentAddForm : Form
    {
        public Student CurrentStudent { get; set; }
        public StudentAddForm()
        {
            CurrentStudent = new Student();
            InitializeComponent();
        }

        private void ButtonStudentAdd_Click(object sender, EventArgs e)
        {
            CurrentStudent.Name = Convert.ToString(textName.EditValue);
            CurrentStudent.Age = Convert.ToInt32(textAge.EditValue);
            CurrentStudent.RegistrationNumber = Convert.ToInt32(textRegNumber.EditValue);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void StudentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
