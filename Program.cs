using LojaDeHardware.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
/*builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=SP-1491025\\SQLSENAI;Initial Catalog = LojaDeHardware;Integrated Security = True;TrustServerCertificate = True"))*/


builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=DESKTOP-BAH0590\\SQLSERVER2022;Initial Catalog = LojaDeHardware;Integrated Security = True;TrustServerCertificate = True"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
