using Microsoft.EntityFrameworkCore;
using server.DataServices;
using Server.DataServices;
using Server.Interfaces;
using Server.Services;

namespace server.Extensions
{
    public static class ApplicationServiceExtensions
    {
     
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
            {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICostAmountRepository, CostsRepository>();
                        services.AddDbContext<DataContext>(options =>
                {       options.UseSqlite(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
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

