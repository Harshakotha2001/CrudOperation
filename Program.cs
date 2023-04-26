using CrudOperation.data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MVCDemoDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MVCDemoConnectionString")));




// Configure the HTTP request pipeline.
if (!builder.Build().Environment.IsDevelopment())
{
    builder.Build().UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    builder.Build().UseHsts();
}

builder.Build().UseHttpsRedirection();
builder.Build().UseStaticFiles();

builder.Build().UseRouting();

builder.Build().UseAuthorization();

builder.Build().MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

builder.Build().Run();
