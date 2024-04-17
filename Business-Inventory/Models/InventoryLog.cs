using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Inventory.Models
{
    public class InventoryLog
    {
        [Key]
        public int InventoryLogId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }

        [Required]
        public DateTime ChangeDate { get; set; }

        [Required]
        [Range(0, int.MaxValue)] // Assuming QuantityChange cannot be negative
        public int QuantityChange { get; set; }

        [Required]
        [StringLength(100)] // Adjust the max length according to your needs
        public string ChangeReason { get; set; }
    }
}
