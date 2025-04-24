using LegoCollectionUI.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace LegoCollectionUI.Clients
{
    public class ColorsClient(HttpClient httpClient)
    {
        //private readonly ColorList[] colors =
        //    [
        //    new(){
        //        Id = 1,
        //        Name = "Red"
        //    },
        //    new(){
        //        Id = 2,
        //        Name = "White"
        //    },
        //    new(){
        //        Id = 3,
        //        Name = "Transparent Neon Orange"
        //    },
        //    new(){
        //        Id = 4,
        //        Name = "Transparent Blue"
        //    },
        //    new(){
        //        Id = 5,
        //        Name="Black"
        //    },
        //    new(){
        //        Id = 6,
        //        Name="Brown"
        //    },
        //    new(){
        //        Id = 7,
        //        Name="Blue"
        //    },
        //    new(){
        //        Id = 8,
        //        Name="Purple"
        //    },
        //    new(){
        //        Id = 9,
        //        Name="Clear"
        //    },
        //    new(){
        //        Id = 10,
        //        Name="Lime"
        //    }
        //    ];

        public async Task<ColorList[]> GetColorsAsync()
            => await httpClient.GetFromJsonAsync<ColorList[]>("colors") ?? [];
    }
}
