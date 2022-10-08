using Microsoft.EntityFrameworkCore;
using Server.DataServices;
using Server.Helpers;
using Server.Interfaces;
using Server.Services;

namespace Server.Extensions
{
    public static class ApplicationServiceExtensions
    {
             public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
            {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICostAmountRepository, CostsRepository>();
            services.AddScoped<ICostCategoryRepository, CategoriesRepository>();
            services.AddScoped<IUserRepository, AppUserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            services.AddDbContext<DataContext>(options =>
                         {  options.UseSqlite(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));  }
           );
       
                services.AddControllers();
                services.AddEndpointsApiExplorer();
                services.AddSwaggerGen();
                services.AddCors();
                         
                return services;
            }


        }
    }

