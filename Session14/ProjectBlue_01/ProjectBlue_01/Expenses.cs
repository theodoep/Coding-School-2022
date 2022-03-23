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
    public partial class Expenses : Form
    {
        public CoffeeShop CurrentShop { get; set; } = new CoffeeShop();
        public Transaction CurrentTransaction{ get; set; }
        public BindingSource bsTransaction { get; set; }

        public Expenses()
        {
            InitializeComponent();
            bsTransaction = new BindingSource();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnReport_Click(object sender, EventArgs e) {
            string month = monthEdit1.SelectedItem.ToString();
            //int month2 = Int32.Parse(monthEdit1.SelectedItem.ToString());

            int year = Int32.Parse(textBoxYear.Text);

            //CurrentTransaction.LoadTransaction();
            CurrentShop.LoadTransactions();
            grdTransactions.DataSource = CurrentShop.Transactions;
            bsTransaction.ResetBindings(true);
        }

        private void Expenses_Load(object sender, EventArgs e) {
            //CurrentTransaction.LoadTransaction();
            CurrentShop.LoadTransactions();
            grdTransactions.DataSource = CurrentShop.Transactions;
            bsTransaction.ResetBindings(true);
        }
    }
}
