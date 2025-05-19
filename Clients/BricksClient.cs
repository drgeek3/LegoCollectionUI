using LegoCollectionUI.Models;
using System.Net.Http;

namespace LegoCollectionUI.Clients
{
    public class BricksClient(HttpClient httpClient)
    {
        public async Task<BricksModel[]> GetBricksAsync() => await httpClient.GetFromJsonAsync<BricksModel[]>("bricks") ?? [];

        public async Task<BricksModel[]> GetBrickIdAsync(string brickid)
           => await httpClient.GetFromJsonAsync<BricksModel[]>($"bricks/brick/{brickid}")
           ?? throw new Exception("Could not find brick.");

        public async Task AddBricksAsync(BricksModel brick)
            => await httpClient.PostAsJsonAsync("bricks", brick);

        public async Task<BricksModel> GetBricksAsync(int id)
            => await httpClient.GetFromJsonAsync<BricksModel>($"bricks/{id}")
                ?? throw new Exception("Could not find brick.");

        public async Task UpdateBricksAsync(BricksModel updatedBricks)
            => await httpClient.PutAsJsonAsync($"bricks/{updatedBricks.Id}", updatedBricks);
        public async Task DeleteBricksAsync(int id)
            => await httpClient.DeleteAsync($"bricks/{id}");

    }
}

