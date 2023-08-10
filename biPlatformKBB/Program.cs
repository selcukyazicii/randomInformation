using Business.Abstract.BiDijitalMedya;
using Business.Concrete.BiDijitalMedya;
using DataAccess.Abstract.BiDijitalMedya;
using DataAccess.Concrete.EntityFramework.BiDijitalMedya;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IContactService, ContactManager>();
builder.Services.AddSingleton<IContactDal, EfContactDal>();
builder.Services.AddSingleton<IAboutUsService, AboutUsManager>();
builder.Services.AddSingleton<IAboutUsDal, EfAboutUsDal>();
builder.Services.AddSingleton<IAboutService, AboutManager>();
builder.Services.AddSingleton<IAboutDal, EfAboutDal>();
builder.Services.AddTransient<bidijital_about>();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(opt =>
            {
                opt.LoginPath = "/Admin/Login/";
            }); 
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=Panel}/{id?}");

app.Run();

    

