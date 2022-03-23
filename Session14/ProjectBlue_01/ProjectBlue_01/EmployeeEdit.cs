using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopForms
{
    public partial class EmployeeEdit : Form
    {
        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsEmployees { get; set; }
        
        public EmployeeEdit()
        {
            InitializeComponent();
            bsEmployees = new BindingSource();
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            bsEmployees.DataSource = CurrentShop.Employees;
            gridControlEmployees.DataSource = bsEmployees;
            gridView1.Columns["ID"].Visible = false;
        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
            CurrentShop.SaveEmployees();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            if(CurrentShop.Employees.FindAll(emp => emp.EmployeeType.ToString() == "Manager").Count < 2)
            {   
                Employee emp = new Employee();
                CurrentShop.Employees.Add(emp);
                bsEmployees.ResetBindings(true);
            }
            //CurrentShop.Employees.Add(emp);
            //bsEmployees.ResetBindings(true);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DeleteButtonEmp_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null)
                return;

            Employee selectedEmployee = gridView1.GetFocusedRow() as Employee;

            Guid selectedID = selectedEmployee.ID;
            CurrentShop.Employees.RemoveAll(emp => emp.ID == selectedID);
            bsEmployees.ResetBindings(true);
        }
    }
}
