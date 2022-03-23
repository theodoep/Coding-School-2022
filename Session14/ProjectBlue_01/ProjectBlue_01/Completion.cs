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
    public partial class Completion : Form
    {
        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsOrder { get; set; }

        public Completion()
        {
            InitializeComponent();
            bsOrder = new BindingSource();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
             if (res == DialogResult.OK)
            {
                Transaction transaction = new Transaction();
                transaction.Lines = CurrentShop.BasketL;
                //CurrentShop.SaveTransaction();
                //transaction.SaveTransaction(transaction);

                MessageBox.Show("You order is Confirmed");

                Customer customer = new Customer();
                CurrentShop.SaveCustomer();
                CurrentShop.CustomerCode++; // should be drawn from customer json, but no time
                this.Close();
            }
             if (res == DialogResult.Cancel)
            {
                MessageBox.Show("Your Order is Canceled");
            }
        }

        private void Completion_Load(object sender, EventArgs e) {

            //grdOrder.DataSource = CurrentShop.Basket;
            //grvOrder.Columns["ProductCategoryID"].Visible = false;
            //grvOrder.Columns["ID"].Visible = false;
            //bsOrder.ResetBindings(true);


            Transaction trans = new Transaction();           
            //double d = trans.GetTotalPrice(CurrentShop.BasketL);
            trans.ApplyDisc(CurrentShop.BasketL);

            grdOrder.DataSource = CurrentShop.BasketL;
            grvOrder.Columns["ProductID"].Visible = false;
            grvOrder.Columns["ID"].Visible = false;
            //grvOrder.Columns["LineStr"].Visible = false;
            grvOrder.Columns["LineCost"].Visible = false;
            bsOrder.ResetBindings(true);

            double _total;
            string _transDetails;
            int _custCode = 001;


            //var timer = new Timer();
            DateTime _date  = new DateTime();
            _total = trans.GetTotalPrice(CurrentShop.BasketL);

            if(_total > 50) {
                rbCard.Enabled = false;
            }

            if(_total >= 10) {
                lblDisc.Text = "Discount: 15%";
                _total = _total - _total*(0.15);
                btnDisc.Enabled = true;
            }

            _transDetails = "Employee: " + trans.EmployeeID + "\nCustomer: " + _custCode + "\nTotal: "
                + _total + "\n" + _date.TimeOfDay.ToString();//trans.Date.ToString();

            richTextBox1.Text = _transDetails;


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (grvOrder.GetFocusedRow() == null)
                return;

            Product selectedProduct = grvOrder.GetFocusedRow() as Product;

            Guid selectedID = selectedProduct.ID;
            CurrentShop.Basket.RemoveAll(prod => prod.ID == selectedID);
            bsOrder.ResetBindings(true);
        }

        //private void btnRemove_Click(object sender, EventArgs e) {
        //    if (grvOrder.GetFocusedRow() == null)
        //        return;

        //    Product selectedProduct = grvOrder.GetFocusedRow() as Product;

        //    try {
        //        Guid selectedID = selectedProduct.ID;
        //        CurrentShop.Basket.RemoveAll(prod => prod.ID == selectedID);
        //        bsOrder.ResetBindings(true);
        //    }
        //    catch (Exception ex) { }
        //}

        private void btnDisc_Click(object sender, EventArgs e) {

        }
    }
}
