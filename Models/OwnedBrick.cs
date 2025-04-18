namespace LegoCollectionUI.Models
{
    public class OwnedBrick
    {
        public required string BrickId { get; set; }        
        public required string Color { get; set; }
        public int Count { get; set; }
        public required string LocationId { get; set; } 

    }
}
