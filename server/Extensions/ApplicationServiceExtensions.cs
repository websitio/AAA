using Microsoft.EntityFrameworkCore;
using server.DataServices;

namespace server.Extensions
{
    public static class ApplicationServiceExtensions
    {
     
        public static IServiceCollection AddApplicationUsersService(this IServiceCollection services)
            {
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(Environment.GetEnvironmentVariable("DefautConnection"));
             //       options.UseSqlite(config.GetConnectionString("DefautConnection"));
                }
           );
       
                services.AddControllers();
                services.AddEndpointsApiExplorer();
                services.AddSwaggerGen();
                services.AddCors();

                
                
              
                return services;
            }


        }
    }

