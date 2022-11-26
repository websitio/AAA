using Microsoft.EntityFrameworkCore;
using Server.Entities;

namespace Server.DataServices
{
    public class CostsContext : DbContext
    {
        private readonly IConfiguration _config;
        public CostsContext(IConfiguration config)
        { _config = config; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_config.GetConnectionString("DefautConnection")

        ).LogTo(Console.WriteLine, LogLevel.Information);
        }

        public DbSet<Cost> CostAmounts { get; set; }


    }
}