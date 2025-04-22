using System.ComponentModel.DataAnnotations;

namespace LegoCollectionUI.Models
{
    public class BrickDetails
    {
        public int Id { get; set; }
        [Required]
        [StringLength(45)]
        public required string BrickId { get; set; }
        [Required(ErrorMessage = "The Color field is required.")]
        public string? ColorId { get; set; }
        [Range(0,100000)]
        public int Count { get; set; }        
        public required string LocationId { get; set; }
    }
}
