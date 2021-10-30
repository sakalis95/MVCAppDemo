using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MvcApp2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Westwind.AspNetCore.LiveReload;

namespace MvcApp2
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
            //For instant updates
            services.AddLiveReload();

            //loginai
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();


            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            //local data
            //services.AddSingleton(new EmployeeRepository());
            //adding interface
            //services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            // database data, reikia scoped
            services.AddScoped<IEmployeeRepository, EmployeeDbRepository>();

            // local movies data
            //services.AddSingleton(new MovieRepository());
            // adding interface
            //services.AddSingleton<IMovieRepository, MovieRepository>();
            // dtaabase datda reikia scoped
            services.AddScoped<IMovieRepository, MovieDbRepository>();

            //login
            services.AddRazorPages();

            //adding DB conncetion
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
           );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //eiliskumas svarbu
                app.UseLiveReload();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            //code base migration - nerekomenduojama praktika. Geriau naudoti kontroliuojamas migracijas
            //using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            //{
            //    var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            //    context.Database.Migrate();
            //}

            // wwwroot files standard
            app.UseStaticFiles();
            // static files (styling) in custom folder
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "MyStaticFolder")),
            //});

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //login
                endpoints.MapRazorPages();
            });


            //  nepamenu
            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context => {
            //        var text = "<h1 style=\"color: red\">Hello, Response!</h1>";
            //        byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            //        await context.Response.Body.WriteAsync(data, 0, data.Length);
            //    });
            //});
        }
    }
}
