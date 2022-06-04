using Microsoft.EntityFrameworkCore;
using server.DataServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefautConnection"));
});


builder.Services.AddControllers();
//more about Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{ var db = scope.ServiceProvider.GetRequiredService<DbContext>(); }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

// app.UseAuthorization();
app.UseDefaultFiles()	;											
app.UseStaticFiles();

app.UseCors( x=> x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.MapControllers();

app.Run();
