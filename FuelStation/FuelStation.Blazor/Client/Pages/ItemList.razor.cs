using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages
{
    public partial class ItemList
    {
        List<ItemListViewModel> itemList = new();
        bool isLoading = true;
        protected override async Task OnInitializedAsync()
        {
            await LoadItemsFromServer();
            isLoading = false;
        }
        private async Task LoadItemsFromServer()
        {
            itemList = await httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
        }
        async Task AddItem()
        {
            navigationManager.NavigateTo("/itemlist/edit");
        }
        async Task EditItem(ItemListViewModel itemToEdit)
        {
            navigationManager.NavigateTo($"/itemlist/edit/{itemToEdit.ID}");
        }
        async Task DeleteItem(ItemListViewModel itemToDelete) //TODO: douleuei me thn 2i fora
        {
            var confirm = await jsRuntime.InvokeAsync<bool>("confirmDelete", null);
            if (confirm)
            {
                var response = await httpClient.DeleteAsync($"item/{itemToDelete.ID}");
                response.EnsureSuccessStatusCode();
                await LoadItemsFromServer();
            }
        }
    }
}
