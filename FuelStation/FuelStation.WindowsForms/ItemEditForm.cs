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
                CurrentItem.Price = numericUpDownPrice.Value;
                ItemTypeEnum itemType;
                Enum.TryParse<ItemTypeEnum>(comboBoxItemType.SelectedValue.ToString(), out itemType);
                CurrentItem.ItemType = itemType;
                CurrentItem.Cost = numericUpDownCost.Value;
                CurrentItem.ID = Guid.Empty;

                response = await httpClient.PostAsJsonAsync("Item1", CurrentItem);
            }
            else
            {
                CurrentItem.Code = textBoxCode.Text;
                CurrentItem.Description = textBoxDescription.Text;
                CurrentItem.Price = numericUpDownPrice.Value;
                ItemTypeEnum itemType;
                Enum.TryParse<ItemTypeEnum>(comboBoxItemType.SelectedValue.ToString(), out itemType);
                CurrentItem.ItemType = itemType;
                CurrentItem.Cost = numericUpDownCost.Value;
                response = await httpClient.PutAsJsonAsync("Item1", CurrentItem);

            }
            response.EnsureSuccessStatusCode();
            this.Close();
        }

        private async void ItemEditForm_Load(object sender, EventArgs e)
        {
            comboBoxItemType.DataSource = Enum.GetValues(typeof(ItemTypeEnum));
            numericUpDownCost.Controls[0].Visible = false;
            numericUpDownPrice.Controls[0].Visible = false;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");

            CurrentItem = await httpClient.GetFromJsonAsync<ItemEditViewModel>($"item1/{SelectedID}");
            CurrentItem.Code = textBoxCode.Text;
            CurrentItem.Description = textBoxDescription.Text;
            CurrentItem.Price = numericUpDownPrice.Value;
            ItemTypeEnum itemType;
            Enum.TryParse<ItemTypeEnum>(comboBoxItemType.SelectedValue.ToString(), out itemType);
            CurrentItem.ItemType = itemType;
            CurrentItem.Cost = numericUpDownCost.Value;
        }
    }
}
