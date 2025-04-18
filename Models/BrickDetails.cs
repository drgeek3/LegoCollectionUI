namespace LegoCollectionUI.Models
{
    public class BrickDetails
    {
        public required string BrickId { get; set; }
        public string? ColorId { get; set; }
        public int Count { get; set; }
        public required string LocationId { get; set; }
    }
}
