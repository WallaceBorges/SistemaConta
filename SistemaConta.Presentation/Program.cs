using Microsoft.AspNetCore.Authentication.Cookies;
using SistemaConta.Presentation.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



AutoMapperConfiguration.Add(builder);
SecurityConfiguration.Add(builder);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Account/Error");
}
app.UseStaticFiles();

app.UseRouting();

SecurityConfiguration.Use(app);


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
