using Microsoft.EntityFrameworkCore;
using server.DataServices;

namespace server.Extensions
{
    public static class ApplicationServiceExtensions
    {
     
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
            {
                services.AddDbContext<DataContext>(options =>
                {       options.UseSqlite(Environment.GetEnvironmentVariable("DefautConnection"));
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

