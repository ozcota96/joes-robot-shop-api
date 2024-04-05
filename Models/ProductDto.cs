namespace JoesRobotShopApi.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageName { get; set; }
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}