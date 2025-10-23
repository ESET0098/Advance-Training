using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManage.cs.Data.Entities;
using BookManage.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer; 


namespace BookManage.cs.Data.Context
{
    public  class MyDbContext(DbContextOptions options) : DbContext(options)
    {
        public IEnumerable<object> User { get; internal set; }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Books> Book { get; set; }
        public DbSet<Customers> customers { get; set; }

        public DbSet<Sales> sales { get; set; }

        public DbSet<SaleItems> saleItems { get; set; }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Admin");

            modelBuilder.Entity<Books>(entity =>
            {
               entity.HasKey(e => e.book_id);
                entity.Property(e => e.title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.author).IsRequired().HasMaxLength(100);
                entity.Property(e => e.current_price).IsRequired().HasColumnType("decimal(18,2)");
            });
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.customer_id);
                entity.Property(e => e.customer_name).IsRequired().HasMaxLength(100);

            });
            modelBuilder.Entity<Sales>(static entity =>
            {
                entity.HasKey(e => e.sale_id);
                entity.Property(e => e.sale_date).IsRequired();
                entity.HasOne(e => e.Customer)
                      .WithMany( c => c.Sales)
                      .HasForeignKey(e => e.customer_id)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<SaleItems>(entity =>
            {
                entity.HasKey(e => e.sale_item_id);
                entity.Property(e => e.quantity_sold).IsRequired();
                entity.Property(e => e.sale_price).IsRequired().HasColumnType("decimal(18,2)");
                entity.HasOne(e => e.Sale)
                      .WithMany(s => s.SaleItems)
                      .HasForeignKey(e => e.sale_id);

                entity.HasOne(e => e.Book)
                    .WithMany(b => b.SaleItems)
                    .HasForeignKey(e => e.book_id);



            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.user_id);
                entity.Property(e => e.username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.password).IsRequired().HasMaxLength(100);
               

            });
        }
    }
}
