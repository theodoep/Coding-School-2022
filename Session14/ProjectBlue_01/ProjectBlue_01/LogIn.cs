using CoffeeShopForms;
using Classes;

namespace ProjectBlue_01
{
    public partial class LogIn : Form
    {
        private Order order;
        private Administrator administrator;
        public CoffeeShop CurrentShop { get; set; }

        public LogIn()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            administrator = new Administrator();
            administrator.ShowDialog();

        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            order = new Order();
            order.ShowDialog();
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}