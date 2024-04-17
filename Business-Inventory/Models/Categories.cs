using System.ComponentModel.DataAnnotations;

namespace Business_Inventory.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)] // Adjust the max length according to your needs
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}
