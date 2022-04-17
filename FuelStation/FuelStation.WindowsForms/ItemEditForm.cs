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
    public partial class ItemEditForm : Form
    {
        public Guid SelectedID { get; set; }
        public ItemEditViewModel CurrentItem { get; set; }
        public ItemEditForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveItemButton_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            HttpResponseMessage response;

            if (SelectedID == Guid.Empty)
            {
                CurrentItem.Code = textBoxCode.Text;
                CurrentItem.Description = textBoxDescription.Text;
                CurrentItem.Price = Convert.ToDecimal(textBoxPrice.Text);
                //Enum Property
                CurrentItem.Cost = Convert.ToDecimal(textBoxCost.Text);
                CurrentItem.ID = Guid.Empty;

                response = await httpClient.PostAsJsonAsync("Item", CurrentItem);
            }
            else
            {
                CurrentItem.Code = textBoxCode.Text;
                CurrentItem.Description = textBoxDescription.Text;
                CurrentItem.Price = Convert.ToDecimal(textBoxPrice.Text);
                //Enum Property
                CurrentItem.Cost = Convert.ToDecimal(textBoxCost.Text);
                response = await httpClient.PutAsJsonAsync("Item", CurrentItem);

            }
            response.EnsureSuccessStatusCode();
            this.Close();
        }

        private async void ItemEditForm_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");

            CurrentItem = await httpClient.GetFromJsonAsync<ItemEditViewModel>($"item/{SelectedID}");
            CurrentItem.Code = textBoxCode.Text;
            CurrentItem.Description = textBoxDescription.Text;
            CurrentItem.Price = Convert.ToDecimal(textBoxPrice.Text);
            //Enum Property
            CurrentItem.Cost = Convert.ToDecimal(textBoxCost.Text);
        }
    }
}
