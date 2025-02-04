using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext> (opt => {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")) ;
} ); // telling our app about the DB created

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scope = app.Services.CreateScope();// intermediaire to access a service
var services = scope.ServiceProvider;

try
{
var context = services.GetRequiredService<DataContext>();
//var userManager = services.GetRequiredService<UserManager<AppUser>>(); //user manager manage users of type AppUser
 await context.Database.MigrateAsync();
 await Seed.SeedData(context);
//await Seed.SeedData(context, userManager) ;

}
catch (Exception ex)
{
var logger = services.GetRequiredService<ILogger<Program>>();
logger.LogError(ex, "An error occured during the migration");

}

app.Run();
