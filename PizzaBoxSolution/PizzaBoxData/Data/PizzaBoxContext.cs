using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBoxData.Data
{
    public partial class PizzaBoxContext : DbContext
    {
        public PizzaBoxContext()
        {
        }

        public PizzaBoxContext(DbContextOptions<PizzaBoxContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerAccountInfo> CustomerAccountInfo { get; set; }
        public virtual DbSet<OrdersPlaced> OrdersPlaced { get; set; }
        public virtual DbSet<StoreInfo> StoreInfo { get; set; }
        public virtual DbSet<StoreInventory> StoreInventory { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=utadbserverdc.database.windows.net;Database=PizzaBoxDB;user id=danielcoombs005;Password=Password123;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<CustomerAccountInfo>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_Customer_ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersPlaced>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK_Order_ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Crust)
                    .HasColumnName("crust")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Dateplaced)
                    .HasColumnName("dateplaced")
                    .HasColumnType("date");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.Subtotal)
                    .HasColumnName("subtotal")
                    .HasColumnType("money");

                entity.Property(e => e.Timeplaced).HasColumnName("timeplaced");

                entity.Property(e => e.Topping1)
                    .HasColumnName("topping1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Topping2)
                    .HasColumnName("topping2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Topping3)
                    .HasColumnName("topping3")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Topping4)
                    .HasColumnName("topping4")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Topping5)
                    .HasColumnName("topping5")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrdersPlaced)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer_ID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.OrdersPlaced)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Order_Store_ID");
            });

            modelBuilder.Entity<StoreInfo>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK_Store_ID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreInventory>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK_Inventory_ID");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.Bacon).HasColumnName("bacon");

                entity.Property(e => e.Cheese).HasColumnName("cheese");

                entity.Property(e => e.Dough).HasColumnName("dough");

                entity.Property(e => e.Mushroom).HasColumnName("mushroom");

                entity.Property(e => e.Olive).HasColumnName("olive");

                entity.Property(e => e.Onion).HasColumnName("onion");

                entity.Property(e => e.Pepperoni).HasColumnName("pepperoni");

                entity.Property(e => e.Pineapple).HasColumnName("pineapple");

                entity.Property(e => e.Sauce).HasColumnName("sauce");

                entity.Property(e => e.Sausage).HasColumnName("sausage");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreInventory)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Inventory_Store_ID");
            });
        }
    }
}
