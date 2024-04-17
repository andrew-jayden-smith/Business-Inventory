using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Inventory.Models
{
    public class SaleDetail
    {
        [Key]
        public int SaleDetailId { get; set; }

        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public virtual Sales Sale { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }

        public int Quantity { get; set; }

        public decimal PriceAtSale { get; set; }
    }
}
