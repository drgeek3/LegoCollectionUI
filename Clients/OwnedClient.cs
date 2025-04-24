using LegoCollectionUI.Models;

namespace LegoCollectionUI.Clients
{
    public class OwnedClient(HttpClient httpClient)
    {
        public async Task<OwnedBrick[]> GetOwnedBricksAsync() => await httpClient.GetFromJsonAsync<OwnedBrick[]>("legos/owned") ?? [];

        public async Task<OwnedBrick[]> GetBrickIdAsync(string brickid)
           => await httpClient.GetFromJsonAsync<OwnedBrick[]>($"legos/owned/brick/{brickid}")
           ?? throw new Exception("Could not find brick.");

        public async Task AddBrickAsync(BrickDetails brick) 
            => await httpClient.PostAsJsonAsync("legos/owned", brick);

        public async Task<BrickDetails> GetBrickAsync(int id)
            => await httpClient.GetFromJsonAsync<BrickDetails>($"legos/owned/{id}")
                ?? throw new Exception("Could not find brick.");

        public async Task UpdateBrickAsync(BrickDetails updatedBrick)
            => await httpClient.PutAsJsonAsync($"legos/owned/{updatedBrick.Id}", updatedBrick);

        public async Task DeleteBrickAsync(int id)
            => await httpClient.DeleteAsync($"legos/owned/{id}");

    }    
}
