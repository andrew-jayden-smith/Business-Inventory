using Microsoft.EntityFrameworkCore;
using Business_Inventory.Models;

namespace PatientPortalWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        // Creating new tables
        public DbSet<Categories> Categories { get; set; }
        public DbSet<InventoryLog> InventoryLog { get; set; }

        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<SaleDetail> SaleDetail { get; set; }

        public DbSet<Sales> Sales { get; set; }

        public DbSet<Users> Users { get; set; }


    }
}
