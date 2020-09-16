using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using vuonsendaMVC.Models;

namespace vuonsendaMVC
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

            var connection = @"Data Source=.;Initial Catalog=SenDaDB;Persist Security Info=True;User ID=sa;Password=123456";
            services.AddDbContext<DBContext>(option => option.UseSqlServer(connection));

          ////  services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
           services.AddSession(option => {                    // Đăng ký dịch vụ Session
          //     // option.Cookie.Name = "Session";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
          //      option.IdleTimeout = new TimeSpan(0, 60, 0);    // Thời gian tồn tại của Session
            option.IdleTimeout = TimeSpan.FromMinutes(300);
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();// cấu hình cho nhận file tỉnh trong wwwroot

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseCookiePolicy();
           
        }
    }
}
