namespace LegoCollectionUI.Models
{
    public class BrickReport
    {
        public required string BrickId { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required string Subcategory { get; set; }
        public required string Container { get; set; }
        public required string Unit { get; set; }
        public int UnitRow { get; set; }
        public int Drawer { get; set; }
        public required string Color { get; set; }
        public int NumAvailable { get; set; }
        public int NumInUse { get; set; }
        public string? AltBrickId { get; set; }
        public bool Overloaded { get; set; }
        public bool Underfilled { get; set; }
        public bool LocEmpty { get; set; }

    }
}
