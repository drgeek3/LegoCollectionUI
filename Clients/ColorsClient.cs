using LegoCollectionUI.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace LegoCollectionUI.Clients
{
    public class ColorsClient
    {
        private readonly ColorList[] colors =
            [
            new(){
                Id = 1,
                Name = "Red"
            },
            new(){
                Id = 2,
                Name = "White"
            },
            new(){
                Id = 3,
                Name = "Transparent Neon Orange"
            },
            new(){
                Id = 4,
                Name = "Transparent Blue"
            },
            new(){
                Id = 5,
                Name="Black"
            }
            ];

        public ColorList[] GetColors() => colors;
    }
}
