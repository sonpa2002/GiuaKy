using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GiuaKy.Data;
using GiuaKy.Areas.Identity.Data;
using GiuaKy;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GiuaKyContextConnection") ?? throw new InvalidOperationException("Connection string 'GiuaKyContextConnection' not found.");

builder.Services.AddDbContext<GiuaKyContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<GiuaKyDBcontext > (options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<GiuaKyUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<GiuaKyContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
