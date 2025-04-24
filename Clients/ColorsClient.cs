using LegoCollectionUI.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace LegoCollectionUI.Clients
{
    public class ColorsClient(HttpClient httpClient)
    {
        public async Task<ColorList[]> GetColorsAsync()
            => await httpClient.GetFromJsonAsync<ColorList[]>("colors") ?? [];
    }
}
