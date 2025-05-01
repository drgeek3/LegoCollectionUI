using LegoCollectionUI.Models;
using System.Net.Http;

namespace LegoCollectionUI.Clients
{
    public class FullBrickReportClient (HttpClient httpClient)
    {
        public async Task<List<BrickReport>> GetBrickReportAsync() 
            => await httpClient.GetFromJsonAsync<List<BrickReport>>("legos") ?? [];

        public async Task<List<BrickReport>> GetSingleBrickAsync(string brickId) 
            => await httpClient.GetFromJsonAsync<List<BrickReport>>($"legos/{brickId}") ?? [];

        public async Task AddFullReportAsync(BrickReport brick) 
            => await httpClient.PostAsJsonAsync("legos", brick);
    }
}
