using AllUpFinal.DataAccessLayer;
using AllUpFinal.Interfaces;
using AllUpFinal.Servicess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddScoped<ILayoutService, LayoutService>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
});
builder.Services.AddHttpContextAccessor();

var app = builder.Build();
app.UseSession();

app.UseStaticFiles();
app.MapControllerRoute("{default}", "{controller=Home}/{action=Index}/{id?}");

app.Run();

