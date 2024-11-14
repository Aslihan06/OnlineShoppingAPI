using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShoppingAPI.DataAccess.Entities;

namespace OnlineShoppingAPI.DataAccess.Contexts
{
    // DbContext sınıfından türeyen OnlineShoppingDbContext sınıfını tanımlıyoruz
    public class OnlineShoppingDbContext : DbContext
    {
        // Constructor: DbContextOptions parametresi alır
        public OnlineShoppingDbContext(DbContextOptions<OnlineShoppingDbContext> options)
            : base(options) // DbContext'in options'ını miras alınan sınıfa gönderir
        {
        }

        // Veritabanındaki tabloları temsil eden DbSet özellikleri
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }

        // Model oluşturma ve ilişkileri tanımlama
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Çoka çok ilişki tanımı: OrderProduct için
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId }); // Bileşik anahtar

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductId);

            // User tablosu için benzersiz kısıtlama
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique(); // Email alanının benzersiz olması

            // Veri türü ayarları
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); // Price için veri türü tanımı

            // Order tablosu için gerekli alanlar
            modelBuilder.Entity<Order>()
                .Property(o => o.OrderDate)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            // Maintenance tablosu için ek yapılandırmalar
            modelBuilder.Entity<Maintenance>()
                .Property(m => m.IsInMaintenance)
                .HasDefaultValue(false); // Varsayılan değer olarak false atanır


        }
    }
}

