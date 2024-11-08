using System.ComponentModel.DataAnnotations;

namespace InventorymngCF.Models
{
    public class OrderDTO
    {
        [Key]
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; } = null!;
    }
}
