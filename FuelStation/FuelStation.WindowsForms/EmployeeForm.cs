using FuelStation.Blazor.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace FuelStation.WindowsForms
{
    public partial class EmployeeForm : Form
    {
        public List <EmployeeListViewModel> Employees { get; set; }
        public BindingSource bsEmployees { get; set; }
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("Employee");
            Employees = response;
            if (Employees == null)
                Employees = new List<EmployeeListViewModel>();
            bsEmployees = new BindingSource();
            bsEmployees.DataSource = Employees;
            dataGridEmployees.DataSource = bsEmployees;
            dataGridEmployees.Columns["ID"].Visible = false;


        }

        private async Task SaveEmployeeButton_ClickAsync(object sender, EventArgs e)
        {
            var row = dataGridEmployees.CurrentRow;
            var IDtoSave = row.Cells["ID"].Value;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.DeleteAsync($"employee/{IDtoSave}");
            response.EnsureSuccessStatusCode();
            await RefreshData();
        }

        private async Task buttonDeleteEmployee_ClickAsync(object sender, EventArgs e)
        {
            var row = dataGridEmployees.CurrentRow;
            var IDtoDelete = row.Cells["ID"].Value;
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.DeleteAsync($"employee/{IDtoDelete}");
            response.EnsureSuccessStatusCode();
            await RefreshData();
        }

        private async void buttonRefreshEmp_Click(object sender, EventArgs e)
        {
            await RefreshData();
        }
        public async Task RefreshData()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7134/");
            var response = await httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("Employee");

            Employees = response;
            bsEmployees.DataSource = Employees;
            dataGridEmployees.Refresh();
        }
    }
}
