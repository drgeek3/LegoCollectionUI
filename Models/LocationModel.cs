using System.ComponentModel.DataAnnotations;

namespace LegoCollectionUI.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(45)]
        public required string LocationId { get; set; }
        [Required]
        [StringLength(45)]
        public required string Container { get; set; }
        public required string Unit { get; set; }
        public int UnitRow { get; set; }
        public int Drawer { get; set; }
        public bool Overloaded { get; set; }
        public bool Underfilled { get; set; }
        public bool LocationEmpty { get; set; }
    }
}
