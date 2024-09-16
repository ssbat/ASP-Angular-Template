using Library.Entities;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Library.Entities.Configurations;

namespace Library.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Laptop> Laptops { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<Laptop>(new LaptopConfiguration());

        }
    }
}
