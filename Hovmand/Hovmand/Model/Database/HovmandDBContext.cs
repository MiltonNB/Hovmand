using Hovmand.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hovmand.Model.Database
{
    public class HovmandDBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Pipeline> Pipeline { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>().Ignore(item => item.Key);
            modelBuilder.Entity<Customer>().Ignore(item => item.Key);
            modelBuilder.Entity<Product>().Ignore(item => item.Key);
            modelBuilder.Entity<Pipeline>().Ignore(item => item.Key);
            modelBuilder.Entity<User>().Ignore(item => item.Key);
            modelBuilder.Entity<Lead>().Ignore(item => item.Key);
        }
    }
}