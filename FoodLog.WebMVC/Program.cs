using FoodLog.BLL;
using FoodLog.DAL.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Portal.Web;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<FoodLogDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodLogContext")));
builder.Services.AddDbContext<FoodLogDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("FoodLogContext"));
});




builder.Services.AddRazorPages();
builder.Services.AddScoped<UnitOfWork>();

builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => {
        options.LoginPath = new PathString("/Account/Login");
        options.AccessDeniedPath = new PathString("/Home/AccessDenied");
    });



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Consumptions}/{action=Index}/{id?}");

app.Run();
