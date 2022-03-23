using Classes;
using ProjectBlue_01;
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
    public partial class Administrator : Form
    {
        public CoffeeShop CurrentShop { get; set; }
        private LogIn logIn;
        private Expenses expenses;
        private EmployeeEdit employeeEdit;
         
        private MenuGrv menu;
        public Administrator()

        {
            InitializeComponent();
            CurrentShop = new CoffeeShop();

           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            expenses = new Expenses();
            expenses.ShowDialog();
        }

        private void EmployeeEdit_Click(object sender, EventArgs e)
        {
            employeeEdit = new EmployeeEdit();
            employeeEdit.CurrentShop = CurrentShop;
            employeeEdit.ShowDialog();
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            menu = new MenuGrv();
            menu.CurrentShop = CurrentShop;
            menu.ShowDialog();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            try
            {
                CurrentShop.LoadEmployees();
            }
            catch { }

        }
    }
}

