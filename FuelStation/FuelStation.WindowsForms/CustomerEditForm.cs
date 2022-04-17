using FuelStation.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WindowsForms
{
    public partial class CustomerEditForm : Form
    {
        public Guid SelectedID { get; set; }
        public CustomerEditViewModel CurrentCustomer { get; set; }
        public CustomerEditForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveCustomersButton_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            HttpResponseMessage response;

            if (SelectedID == Guid.Empty)
            {
                CurrentCustomer.Name = textBoxName.Text;
                CurrentCustomer.Surname = textBoxSurname.Text;
                CurrentCustomer.CardNumber = textBoxCardNumber.Text;
                CurrentCustomer.ID = Guid.Empty;

                response = await httpClient.PostAsJsonAsync("Customer",  CurrentCustomer);
            }
            else
            {
               
                CurrentCustomer.Name = textBoxName.Text;
                CurrentCustomer.Surname = textBoxSurname.Text;
                CurrentCustomer.CardNumber = textBoxCardNumber.Text;
                response = await httpClient.PutAsJsonAsync("Customer", CurrentCustomer);
            }
            response.EnsureSuccessStatusCode();
            this.Close(); 
        }

        private async void CustomerEditForm_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            
            CurrentCustomer = await httpClient.GetFromJsonAsync<CustomerEditViewModel>($"customer/{SelectedID}");
            textBoxName.Text = CurrentCustomer.Name;
            textBoxSurname.Text = CurrentCustomer.Surname;
            textBoxCardNumber.Text = CurrentCustomer.CardNumber;
        }
    }
}
