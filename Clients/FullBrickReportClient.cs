using LegoCollectionUI.Models;
using System.Net.Http;

namespace LegoCollectionUI.Clients
{
    public class FullBrickReportClient (HttpClient httpClient)
    {
        private readonly List<BrickReport> bricks =
        [
        new (){
            BrickId = "1234",
            Description = "Sample Brick",
            Category = "Basic",
            Subcategory = "Brick",
            Container = "Rack",
            Unit = "A",
            UnitRow = "1",
            Drawer = "1",
            Color = "White",
            Count = 28,
            Overloaded = false,
            Underfilled = false,
            LocEmpty = false    },
        new (){
            BrickId = "5678",
            Description ="4x2 Wall Panel w Studs",
            Category = "Wall",
            Subcategory = "Panel",
            Container = "Rack",
            Unit = "A",
            UnitRow = "1",
            Drawer = "5",
            Color = "Red",
            Count = 5,
            Overloaded = false,
            Underfilled = true,
            LocEmpty = false    },
        new (){
            BrickId = "29568",
            Description ="3x3 Four Way Cross Tile",
            Category = "Brick",
            Subcategory = "Tile",
            Container = "Rack",
            Unit = "A",
            UnitRow = "2",
            Drawer = "7",
            Color = "Transparent Neon Orange",
            Count = 5,
            Overloaded = false,
            Underfilled = false,
            LocEmpty = false    },
        new (){
            BrickId = "4122",
            Description ="2x7 Tile with edge",
            Category = "Brick",
            Subcategory = "Tile",
            Container = "Rack",
            Unit = "A",
            UnitRow = "2",
            Drawer = "8",
            Color = "Transparent Blue",
            Count = 31,
            Overloaded = false,
            Underfilled = false,
            LocEmpty = false    }
        ];


        public async Task<BrickReport[]> GetBrickReportAsync() => await httpClient.GetFromJsonAsync<BrickReport[]>("/") ?? [];
    }
}
