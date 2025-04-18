using LegoCollectionUI.Models;

namespace LegoCollectionUI.Clients
{
    public class OwnedClient
    {
        private readonly List<OwnedBrick> bricks =
        [
            new (){
            BrickId = "1234",
            Color = "White",
            Count = 28,
            LocationId = "RA11"    },
            new (){
            BrickId = "5678",
            Color = "Red",
            Count = 5,
            LocationId = "RA15"    },
            new (){
            BrickId = "29568",
            Color = "Transparent Neon Orange",
            Count = 5,
            LocationId = "RA27"    },
            new (){
            BrickId = "4122",
            Color = "Transparent Blue",
            Count = 31,
            LocationId = "RA28"    }
        ];

        private readonly ColorList[] colors = new ColorsClient().GetColors();

        public OwnedBrick[] GetOwnedBricks() => [.. bricks];

        public void AddBrick(BrickDetails brick)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(brick.ColorId);
            var colorList = colors.Single(colorList => colorList.Id == int.Parse(brick.ColorId));

            var ownedBrick = new OwnedBrick
            {
                BrickId = brick.BrickId,
                Color = colorList.Name,
                Count = brick.Count,
                LocationId = brick.LocationId
            };

            bricks.Add(ownedBrick);
        }

    }    
}
