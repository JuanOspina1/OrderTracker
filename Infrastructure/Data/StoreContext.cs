using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<PurchaseOrder>()
        //         .OwnsMany(po => po.Items, item =>
        //         {
        //             item.Property(i => i.ItemName).HasColumnName("ItemName");
        //             item.Property(i => i.Quantity).HasColumnName("Quantity");
        //             item.Property(i => i.Price).HasColumnName("Price");
        //             item.Property(i => i.Description).HasColumnName("Description");


        //             // Configure other item-related properties
        //         });
        // }
    }
}