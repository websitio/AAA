using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace server.DataServices
{
    public class DataContext : DbContext
    {

        private readonly IConfiguration _config;
        public DataContext(IConfiguration config)
        {            _config = config;        }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite(_config.GetConnectionString("DefautConnection"));
            }
    
             public DbSet<AppUser> Users { get; set; }

    }
}
