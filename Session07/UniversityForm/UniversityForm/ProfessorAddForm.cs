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
    public partial class ProfessorAddForm : Form
    {
        public Professor CurrentProfessor { get; set; }
        public ProfessorAddForm()
        {
            CurrentProfessor = new Professor();
            InitializeComponent();
        }

        private void ButtonProfessorAdd_Click(object sender, EventArgs e)
        {
            CurrentProfessor.Name = Convert.ToString(textName.EditValue);
            CurrentProfessor.Age = Convert.ToInt32(textAge.EditValue);
            CurrentProfessor.Rank = Convert.ToString(textRank.EditValue);
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
