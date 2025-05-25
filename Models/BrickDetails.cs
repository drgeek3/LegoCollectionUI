using LegoCollectionUI.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LegoCollectionUI.Models
{
    public class BrickDetails
    {
        public int Id { get; set; }
        [Required]
        [StringLength(45)]
        public required string BrickId { get; set; }
        [Required(ErrorMessage = "The Color field is required.")]
        [JsonConverter(typeof(StringConverter))]
        public string? ColorId { get; set; }
        [Range(0,100000)]
        public int NumAvailable { get; set; }
        [Range(0,100000)]
        public int NumInUse { get; set; }
        [Required(ErrorMessage = "Location Id is required.")]
        public required string LocationId { get; set; }
    }
}
