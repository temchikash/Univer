using Microsoft.EntityFrameworkCore;

namespace VUZ
{
    public class DBContext : DbContext
    {
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<VUZ> VUZS { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Univer.db");
        }
        
    }
}
