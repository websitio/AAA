using server.Extensions;
namespace server; 
 public static class Startup
     {
        public static WebApplication InitializeApp(string[] args)
        {               var builder = WebApplication.CreateBuilder(args);
                        ConfigureServices(builder);
                        var app = builder.Build();
                        Configure(app);
            return app;
        }
        public static void ConfigureServices(WebApplicationBuilder builder)
        {               builder.Services.AddApplicationUsersService();                   }

        private static void Configure(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {            app.UseSwagger();      app.UseSwaggerUI();                        }

        app.UseAuthentication();
        app.UseAuthorization();
        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        app.MapControllers();
    }
}
