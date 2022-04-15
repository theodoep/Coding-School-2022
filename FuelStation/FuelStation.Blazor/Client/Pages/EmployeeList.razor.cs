using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages
{
    public partial class EmployeeList
    {
        List<EmployeeListViewModel> employeeList = new();
        bool isLoading = true;
        protected override async Task OnInitializedAsync()
        {
            await LoadItemsFromServer();
            isLoading = false;
        }
        private async Task LoadItemsFromServer()
        {
            employeeList = await httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("Employee");
        }
        async Task AddItem()
        {
            navigationManager.NavigateTo("/employeelist/edit");
        }
        async Task EditItem(EmployeeListViewModel itemToEdit)
        {
            navigationManager.NavigateTo($"/employeelist/edit/{itemToEdit.ID}");
        }
        async Task DeleteItem(EmployeeListViewModel itemToDelete) //TODO: douleuei me thn 2i fora
        {
            var confirm = await jsRuntime.InvokeAsync<bool>("confirmDelete", null);
            if (confirm)
            {
                var response = await httpClient.DeleteAsync($"employee/{itemToDelete.ID}");
                response.EnsureSuccessStatusCode();
                await LoadItemsFromServer();
            }
        }
    }
}
