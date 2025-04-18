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
        public required string UnitRow { get; set; }
        public required string Drawer { get; set; }
        public required string Color { get; set; }
        public int Count { get; set; }
        public bool Overloaded { get; set; }
        public bool Underfilled { get; set; }
        public bool LocEmpty { get; set; }

    }
}
