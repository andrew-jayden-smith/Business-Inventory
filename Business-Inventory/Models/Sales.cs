using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Business_Inventory.Models
{
    public class Sales
    {
        [Key]
        public int SaleId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual Users User { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
