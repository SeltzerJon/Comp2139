using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRouting(Options =>
{
    Options.AppendTrailingSlash= true;
    Options.LowercaseQueryStrings = true;
});

builder.Services.AddDbContext<ContactContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ContactContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

app.Run();
