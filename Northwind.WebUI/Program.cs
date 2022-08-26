using Microsoft.EntityFrameworkCore;
using Northwind.BL.Abstract;
using Northwind.BL.Concrete;
using Northwind.Entites;

namespace Northwind.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer("Server=.;Database=Northwind;Tursted_Connection=true"));


            // Bagimliklarin eklenmesi 
            builder.Services.AddScoped<IShipperManager, ShipperManager>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}