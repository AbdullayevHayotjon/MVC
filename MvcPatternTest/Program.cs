using Microsoft.EntityFrameworkCore;
using MvcPatternTest.Entities;
using MvcPatternTest.Interfaces;
using MvcPatternTest.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddDbContext<EntityContext>(options =>
                    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=LoginPage}/{id?}");

app.Run();
