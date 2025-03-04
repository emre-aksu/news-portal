var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession();// Session, uygulama genelinde kullanýma açýlýyor

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession(); // Session, uygulama genelinde kullanýma açýlýyor
app.UseAuthorization();



app.MapAreaControllerRoute(
               name: "adminPanelDefault",
               areaName: "GazetePanel",
               pattern: "/gazete/{controller=Home}/{action=List}/{id?}");





app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ekonomi}/{action=Index}/{id?}");

app.Run();
