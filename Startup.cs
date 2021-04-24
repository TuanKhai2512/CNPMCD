using BaiLam.Interfaces;
using BaiLam.Models;
using BaiLam.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiLam.UnitOfWork;

namespace BaiLam
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDbContext<TimeSheetContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("TimeSheetDB")));

            services.AddDbContext<TimeSheetContext>(options =>
            options.UseSqlServer(
             Configuration.GetConnectionString("TimeSheetDB"),
            b => b.MigrationsAssembly(typeof(TimeSheetContext).Assembly.FullName)));
            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUnitOfWork, BaiLam.UnitOfWork.UnitOfWork>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(name: "dashboard",
                            pattern: "dashboard",
                            defaults: new { controller = "Admin", action = "Index" });
                endpoints.MapRazorPages();
            });
           
        }
        
    }
}
