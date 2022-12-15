using BlazorShoes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorShoes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) 
        //{ 
        //    modelBuilder.Entity<OrderItem>().HasKey(nameof(OrderItem.OrderId), nameof(OrderItem.ShoeId)); 
        //}
    }
}