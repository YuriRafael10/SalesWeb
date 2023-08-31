using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMVC.Data;
using SalesWebMVC.Services;

namespace SalesWebMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            /*builder.Services.AddDbContext<SalesWebMVCContext>(options =>
                options.UseMySql(builder.Configuration.GetConnectionString("SalesWebMVCContext"),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("SalesWebMVCContext")),
                builder => builder.MigrationsAssembly("SalesWebMVC")));*/

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionStringMysql = builder.Configuration.GetConnectionString("SalesWebMVCContext");
            builder.Services.AddDbContext<SalesWebMVCContext>(options => options.UseMySql(connectionStringMysql, ServerVersion.Parse("8.0.25-mysql"),
                mysqlOptions =>
                {
                    mysqlOptions.EnableRetryOnFailure(); // Caso tenha falha, sera feito tentativas adicionais para conectar ao bd
                }
                )
            );

            builder.Services.AddScoped<SeedingService>();
            builder.Services.AddScoped<SellerService>();
            builder.Services.AddScoped<DepartmentService>();
            builder.Services.AddScoped<SalesRecordService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();

            app.UseHttpsRedirection();
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