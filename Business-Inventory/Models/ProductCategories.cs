using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Inventory.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }
    }
}
