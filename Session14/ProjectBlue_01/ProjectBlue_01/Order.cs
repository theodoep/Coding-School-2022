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

namespace CoffeeShopForms{
    
        public partial class Order : Form
       
    {
        private Completion completion;
        private Coffee coffee;
        private Beverage beverage;
        private Food food;
        public CoffeeShop CurrentShop { get; set; }
        public Order()
        {
            InitializeComponent();
            CurrentShop = new CoffeeShop();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
           completion = new Completion();
           completion.CurrentShop = CurrentShop;
           completion.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoffeeButton_Click(object sender, EventArgs e)
        {
            coffee = new Coffee();
            coffee.CurrentShop = CurrentShop;
            coffee.ShowDialog();

        }

        private void BeverageButton_Click(object sender, EventArgs e)
        {
            beverage = new Beverage();
            beverage.CurrentShop = CurrentShop;
            beverage.ShowDialog();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            food = new Food();
            food.CurrentShop = CurrentShop;
            food.ShowDialog();
        }

        private void Order_Load(object sender, EventArgs e) {

        }
    }
}
