using LegoCollectionUI.Models;

namespace LegoCollectionUI.Clients
{
    public class OwnedClient
    {
        private readonly List<OwnedBrick> bricks =
        [
            new (){
            Id = 1,
            BrickId = "1234",
            Color = "White",
            Count = 28,
            LocationId = "RA11"    },
            new (){
            Id = 2,
            BrickId = "5678",
            Color = "Red",
            Count = 5,
            LocationId = "RA15"    },
            new (){
            Id = 3,
            BrickId = "29568",
            Color = "Transparent Neon Orange",
            Count = 5,
            LocationId = "RA27"    },
            new (){
            Id = 4,
            BrickId = "4122",
            Color = "Transparent Blue",
            Count = 31,
            LocationId = "RA28"    }
        ];

        private readonly ColorList[] colors = new ColorsClient().GetColors();

        public OwnedBrick[] GetOwnedBricks() => [.. bricks];

        public void AddBrick(BrickDetails brick)
        {
            ColorList colorList = GetColorById(brick.ColorId);

            var ownedBrick = new OwnedBrick
            {
                Id = bricks.Count + 1,
                BrickId = brick.BrickId,
                Color = colorList.Name,
                Count = brick.Count,
                LocationId = brick.LocationId
            };

            bricks.Add(ownedBrick);
        }

        public BrickDetails GetBrick(int id)
        {
            OwnedBrick? brick = GetBrickSummaryById(id);

            var color = colors.Single(color => string.Equals(color.Name, brick.Color, StringComparison.OrdinalIgnoreCase));
            return new BrickDetails
            {
                Id = id,
                BrickId = brick.BrickId,
                ColorId = color.Id.ToString(),
                Count = brick.Count,
                LocationId = brick.LocationId
            };
        }

        public void UpdateBrick(BrickDetails updatedBrick)
        {
            var color = GetColorById(updatedBrick.ColorId);
            OwnedBrick existingBrick = GetBrickSummaryById(updatedBrick.Id);

            existingBrick.BrickId = updatedBrick.BrickId;
            existingBrick.Color = color.Name;
            existingBrick.Count = updatedBrick.Count;
            existingBrick.LocationId = updatedBrick.LocationId;
        }

        private OwnedBrick GetBrickSummaryById(int id)
        {
            var brick = bricks.Find(brick => brick.Id == id);
            ArgumentNullException.ThrowIfNull(brick);
            return brick;
        }

        private ColorList GetColorById(string? id)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(id);
            return colors.Single(colorList => colorList.Id == int.Parse(id));

        }

    }    
}
