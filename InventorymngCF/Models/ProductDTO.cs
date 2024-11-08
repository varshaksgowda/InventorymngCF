namespace InventorymngCF.Models
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string Sku { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public int StockLevel { get; set; }

        public int ReorderLevel { get; set; }

        public int? SupplierId { get; set; }
    }
}
