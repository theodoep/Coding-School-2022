using FuelStation.Blazor.Shared;
using FuelStation.Model;
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
    public partial class CustomerForm : Form
    {
        public List<CustomerListViewModel> Customers { get; set; }
        public BindingSource bsCustomers { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("Customer");
            Customers = response;


            if (Customers == null)
                Customers = new List<CustomerListViewModel>();

            bsCustomers = new BindingSource();
            bsCustomers.DataSource = Customers;
            dataGridCustomers.DataSource = bsCustomers;

            dataGridCustomers.Columns["ID"].Visible = false;
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshData();
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var row = dataGridCustomers.CurrentRow;
            var IDtoDelete = row.Cells["ID"].Value;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.DeleteAsync($"customer/{IDtoDelete}");
            response.EnsureSuccessStatusCode();
            await RefreshData();
        }

        public async Task RefreshData()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("Customer");

            Customers = response;
            bsCustomers.DataSource = Customers;
            dataGridCustomers.Refresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
