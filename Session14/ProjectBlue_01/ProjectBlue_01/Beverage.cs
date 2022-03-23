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
    public partial class Beverage : Form
    {
        private int _quantity { get; set; }
        public CoffeeShop CurrentShop { get; set; }
        public BindingSource bsProducts { get; set; }
        Order order = new Order();
        public Beverage()
        {
            InitializeComponent();
            bsProducts = new BindingSource();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Beverage_Load(object sender, EventArgs e)
        {
            CurrentShop.LoadProduct();
            bsProducts.DataSource = CurrentShop.Products.FindAll(prod => prod.ProductType.ToString() == "Beverage");
            grdBeverage.DataSource = bsProducts.DataSource;
            grvBeverage.Columns["ProductCategoryID"].Visible = false;
            grvBeverage.Columns["ID"].Visible = false;
            bsProducts.ResetBindings(true);
        }

        private void ADD_Click(object sender, EventArgs e) {
            _quantity = Int32.Parse(cbQuantity.SelectedItem.ToString());

            if (_quantity != 0) {
                Product product = grvBeverage.GetFocusedRow() as Product;
                CurrentShop.Basket.Add(product);             

                TransactionLine tra = new TransactionLine(_quantity, product);
                CurrentShop.BasketL.Add(tra);
                MessageBox.Show(_quantity + " " + product.Description + " Added");
            }
            else {
                MessageBox.Show("Select  product quantity");
                return;
            }
        }

        private void grdBeverage_Click(object sender, EventArgs e)
        {

        }

        private void cbQuantity_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
