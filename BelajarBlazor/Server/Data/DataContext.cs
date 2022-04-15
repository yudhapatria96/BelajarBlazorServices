using Microsoft.EntityFrameworkCore;
using BelajarBlazor.Shared;
namespace BelajarBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { id = 1, name = "Yudha", username = "yudha", password = "yudha"}
                );
        }

        public DbSet<User> Users { get; set; }  
    }
}
