using System;
using CustomerApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Data.Database
{
    public class CustomerContext : DbContext
    {

        public CustomerContext()
        {
            
        }

        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {
           
        }

        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "_");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();
            });
        }
    }
}