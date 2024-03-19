using Microsoft.EntityFrameworkCore;
using myapp.DataContext;
using myapp.Home.Providers;
using myapp.Home.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("sqlConnection");
builder.Services.AddDbContext<DatabaseContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddTransient<IHomeProvider,HomeProvider>();
builder.Services.AddTransient<IHomeService, HomeService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
    builder =>builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});
var sessionTimeOutInMinutes = builder.Configuration.GetSection("AppSettings:SessionTimeOutInMinutes").Get<Int32>();
builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
