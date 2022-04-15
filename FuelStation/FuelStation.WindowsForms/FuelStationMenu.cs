using FuelStation.Model;

namespace FuelStation.WindowsForms
{
    public partial class FuelStationMenu : Form
    {

        public FuelStationMenu()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }
    }
}