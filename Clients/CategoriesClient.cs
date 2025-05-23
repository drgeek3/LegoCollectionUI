using LegoCollectionUI.Models;
using System.Net.Http;

namespace LegoCollectionUI.Clients
{
    public class CategoriesClient (HttpClient httpClient)
    {
        public async Task<CategoriesModel[]> GetCategoriesAsync()
    => await httpClient.GetFromJsonAsync<CategoriesModel[]>("bricks/categories") ?? [];
    }
}
