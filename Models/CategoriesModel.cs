namespace LegoCollectionUI.Models
{
    public class CategoriesModel
    {
        public int Id { get; set; }
        public required string Category {  get; set; }
        public bool IsMain { get; set; }
        public string? Subcat { get; set; }
    }
}
