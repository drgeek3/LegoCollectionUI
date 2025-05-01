using System.ComponentModel.DataAnnotations;

namespace LegoCollectionUI.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public string? LocationId { get; set; }
        [Required]
        [StringLength(45)]
        public required string Container { get; set; }
        [Required]
        public required string Unit { get; set; }
        public string? UnitRow { get; set; }
        public string? Drawer { get; set; }
        public bool Overloaded { get; set; }
        public bool Underfilled { get; set; }
        public bool LocationEmpty { get; set; }
    }
}
