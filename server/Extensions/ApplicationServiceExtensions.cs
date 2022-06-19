using Microsoft.EntityFrameworkCore;
using server.DataServices;

namespace server.Extensions
{
    public static class ApplicationServiceExtensions
    {
     
        public static IServiceCollection AddApplicationUsersService(this IServiceCollection services,  IConfiguration config)
            {
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlite(config.GetConnectionString("DefautConnection"));
                }
                                                                                      );
                return services;
            }


        }
    }

