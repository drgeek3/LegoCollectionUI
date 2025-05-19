namespace LegoCollectionUI.Models
{
    public class BricksModel
    {
        public int Id { get; set; }
        public required string BrickId { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required string Subcategory { get; set; }
        public string? AltBrickId { get; set; }
        public string? ImageLoc { get; set; }
    }
}
