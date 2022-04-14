using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages
{
    public partial class TransactionList
    {

        List<TransactionListViewModel> transactionList = new();
        bool isLoading = true;
        protected override async Task OnInitializedAsync()
        {
            await LoadItemsFromServer();
            isLoading = false;
        }
        private async Task LoadItemsFromServer()
        {
            transactionList = await httpClient.GetFromJsonAsync<List<TransactionListViewModel>>("transaction");
        }
        async Task AddItem()
        {
            navigationManager.NavigateTo("/transactionlist/edit");
        }
        async Task EditItem(TransactionListViewModel itemToEdit)
        {
            navigationManager.NavigateTo($"/transactionlist/edit/{itemToEdit.ID}");
        }
        async Task DeleteItem(TransactionListViewModel itemToDelete) //TODO: douleuei me thn 2i fora
        {
            var confirm = await jsRuntime.InvokeAsync<bool>("confirmDelete", null);
            if (confirm)
            {
                var response = await httpClient.DeleteAsync($"transaction/{itemToDelete.ID}");
                response.EnsureSuccessStatusCode();
                await LoadItemsFromServer();
            }
        }
    }
}
