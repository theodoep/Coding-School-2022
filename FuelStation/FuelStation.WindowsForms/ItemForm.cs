using FuelStation.EF.Repositories;
using System.Windows.Forms;
using FuelStation.Model;
using System.Net.Http;
using System.Net.Http.Json;
using FuelStation.Blazor.Shared;

namespace FuelStation.WindowsForms
{
    public partial class ItemForm : Form
    {
        public List<ItemListViewModel> Items { get; set; } 
        public BindingSource bsItems { get; set; }

        public ItemForm()
        {
            InitializeComponent();
        }

        private async void ItemForm_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("Item");
            Items = response;


            if (Items == null)
                Items = new List<ItemListViewModel>();

            bsItems = new BindingSource();
            bsItems.DataSource = Items;
            dataGridViewItems.DataSource = bsItems;

            dataGridViewItems.Columns["ID"].Visible = false;
        }

        private async Task RefreshItems()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("Item");

            Items = response;
            bsItems.DataSource = Items;
            dataGridViewItems.Refresh();
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var itemEdit = new ItemEditForm();
            itemEdit.SelectedID = Guid.Empty; 
            itemEdit.ShowDialog();
            await RefreshItems();
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {

        }

        private void finishedItemButton_Click(object sender, EventArgs e)
        {
            
        }

        private async void deleteItemButton_Click(object sender, EventArgs e)
        {
            var row = dataGridViewItems.CurrentRow; 
            var IDtoDelete = row.Cells["ID"].Value;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.DeleteAsync($"item/{IDtoDelete}");
            response.EnsureSuccessStatusCode();
            await RefreshItems(); 
        }

        private async void refreshItemButton_Click(object sender, EventArgs e)
        {
            await RefreshItems();
        }

        private async void EditItemButton_Click(object sender, EventArgs e)
        {
            var itemEdit = new ItemEditForm();
            var row = dataGridViewItems.CurrentRow;
            if (row is null)
                return;
            var IDtoEdit = row.Cells["ID"].Value;
            itemEdit.SelectedID = (Guid)IDtoEdit;
            itemEdit.ShowDialog();
            await RefreshItems(); 
        }
    }
    
}
