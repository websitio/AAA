
/* using server; var app = Startup.InitializeApp(args); app.Run(); */
using server.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddCors();


var app = builder.Build();

// app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();


if (app.Environment.IsDevelopment())
{ app.UseSwagger(); app.UseSwaggerUI(); }

app.UseAuthentication();
app.UseAuthorization();
app.UseDefaultFiles();
app.UseStaticFiles();
// app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin() );             
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4201"));
app.MapControllers();




await app.RunAsync();


