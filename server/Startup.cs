using server.Extensions;

namespace server
{
        #region pre static        
    /*
    public  class Startup
    {

      
        // public Startup(IConfiguration configuration) { Configuration = configuration; }

        //public IConfiguration Configuration { get; }
     


        public void ConfigureServices(IServiceCollection services)
        { }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        { }

               
        } 
    */
    #endregion

          public static class Startup
         {

        private static IConfiguration config { get; set; }

        public static WebApplication InitializeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }


        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationUsersService(config);

            #region
            //builder.Services.AddAuthentication(options =>
            //{
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            //})
            //     .AddJwtBearer();

            //builder.Services.AddAuthorization();
            #endregion

        }



        private static void Configure(WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            app.MapControllers();

        }



    }


}
