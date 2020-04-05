using System.Threading.Tasks;
using FirstMVCApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Purchase> Purchases { get; set; }
        
        public AppDbContext()
        {
        }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
        
        public Task SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}