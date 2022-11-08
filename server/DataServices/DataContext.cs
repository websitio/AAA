using  Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.DataServices
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _config;
        public DataContext(IConfiguration config)
        {            _config = config;        }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {                optionsBuilder.UseSqlite(_config.GetConnectionString("DefautConnection")
            
            ).LogTo(Console.WriteLine,LogLevel.Information);            }
    
         public DbSet<AppUser> AppUsers { get; set; }
         public DbSet<CostCategory> CostCategories {get; set;}
         public DbSet<CostAmount> CostAmounts {get; set;}
    }
}
