using LegoCollectionUI.Models;
using System.Net.Http;

namespace LegoCollectionUI.Clients
{
    public class LocationClient(HttpClient httpClient)
    {
        public async Task<LocationModel[]> GetLocationsAsync() => await httpClient.GetFromJsonAsync<LocationModel[]>("locations") ?? [];

        public async Task<LocationModel[]> GetLocationIdAsync(string locationid)
           => await httpClient.GetFromJsonAsync<LocationModel[]>($"locations/location/{locationid}")
           ?? throw new Exception("Could not find location.");

        public async Task AddLocationAsync(LocationModel location)
            => await httpClient.PostAsJsonAsync("locations", location);

        public async Task<LocationModel> GetLocationAsync(int id)
            => await httpClient.GetFromJsonAsync<LocationModel>($"locations/{id}")
                ?? throw new Exception("Could not find location.");

        public async Task UpdateLocationAsync(LocationModel updatedLocation)
            => await httpClient.PutAsJsonAsync($"locations/{updatedLocation.Id}", updatedLocation);
        public async Task DeleteLocationAsync(int id)
            => await httpClient.DeleteAsync($"locations/{id}");

    }
}

