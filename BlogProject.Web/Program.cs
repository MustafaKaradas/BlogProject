using BlogProject.BLL;
using BlogProject.DAL.Concrete;
using BlogProject.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BlogProject.DAL.Concrete.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);
//var connectionString = builder.Configuration.GetConnectionString("AppIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'AppIdentityContextConnection' not found.");

//builder.Services.AddDbContext<AppIdentityContext>(options =>
//    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<AppIdentityContext>();



// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddScopedBll();



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme,
        options => builder.Configuration.Bind("JwtSettings", options))
                    .AddCookie("Identity.Application", options =>
                    {
                        options.LoginPath = "/Login/Index";
                    });

//builder.Services.AddIdentity<AppUser, AppRole>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<Ide>(); 

builder.Services.AddRazorPages();

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
app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{

   

      endpoints.MapAreaControllerRoute(
             name: "Admin",
             areaName: "Admin",
             pattern: "Admin/{controller=Admin}/{action=Index}/{id?}");
    endpoints.MapAreaControllerRoute(
             name: "User",
             areaName: "StandartUser",
             pattern: "StandartUser/{controller=StandartUser}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
           name: "default",
           pattern: "{controller=Home}/{action=Index}/{id?}");






    endpoints.MapRazorPages();



});

app.Run();
