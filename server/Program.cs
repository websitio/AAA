using server;


var app = Startup.InitializeApp(args);

#region DI Dbcontext and others for Users commented out
/// var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
//builder.Services.AddDbContext<DataContext>(options =>
// {
//    options.UseSqlite(builder.Configuration.GetConnectionString("DefautConnection"));
// });

//builder.Services.UsersAPI();  <-- this don't work!


//builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddCors();

// var app = builder.Build();

// Configure the HTTP request pipeline.

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//// app.UseHttpsRedirection();
//// app.UseAuthorization();
//app.UseDefaultFiles();
//app.UseStaticFiles();
//app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
//app.MapControllers();
#endregion
app.Run();




