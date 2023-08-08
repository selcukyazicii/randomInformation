using Business.Abstract.BiDijitalMedya;
using Business.Concrete.BiDijitalMedya;
using DataAccess.Abstract.BiDijitalMedya;
using DataAccess.Concrete.EntityFramework.BiDijitalMedya;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IContactService, ContactManager>();
builder.Services.AddSingleton<IContactDal, EfContactDal>();

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
    pattern: "{controller=Main}/{action=Anasayfa}/{id?}");

app.Run();

    

