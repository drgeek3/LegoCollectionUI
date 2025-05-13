using System.ComponentModel.DataAnnotations;

namespace LegoCollectionUI.Models
{
    public class OwnedBrick
    {
        public int Id { get; set; }
        [Required]
        [StringLength(45)]
        public required string BrickId { get; set; }
        [Required(ErrorMessage = "The Color field is required.")]
        public required string Color { get; set; }
        [Range(0, 100000)]
        public int NumAvailable { get; set; }
        public int NumInUse { get; set; }
        public required string LocationId { get; set; } 
        public string? ImageLoc { get; set; }

    }
}
