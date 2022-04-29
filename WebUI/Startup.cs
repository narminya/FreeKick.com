using AutoMapper;
using Domain.Constants;
using Domain.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.DataAccessLayer;
using Repository.Repository.Abstraction;
using Repository.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Hubs;

namespace WebUI
{
    public class Startup
    {
        private readonly IConfiguration _conf;
        private readonly IWebHostEnvironment _env;

        public Startup(IConfiguration conf, IWebHostEnvironment env)
        {
            _conf = conf;
            _env = env;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 10;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddControllersWithViews()
           .AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling
           = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<AppDbContext>(cfg =>
            {
                cfg.UseSqlServer(_conf.GetConnectionString("DefaultConnection"),
                        builder =>
                        {
                            builder.MigrationsAssembly(nameof(Repository));
                        });
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin/Author", policyBuilder => policyBuilder.RequireAssertion(
                     context => context.User.IsInRole(RoleConstants.Admin) ||
                                context.User.IsInRole(RoleConstants.Admin) || context.User.IsInRole(RoleConstants.Author)));

                options.AddPolicy("AreaAdmin", policyBuilder => policyBuilder.RequireAssertion(
                    context => context.User.IsInRole(RoleConstants.Admin)));

                options.AddPolicy("Moderator", policyBuilder => policyBuilder.RequireAssertion(
                  context => context.User.IsInRole(RoleConstants.Moderator)));
                
                options.AddPolicy("Author", policyBuilder => policyBuilder.RequireAssertion(
                  context => context.User.IsInRole(RoleConstants.Author)));
            });



            services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));

            services.AddTransient(typeof(IBroadcastRepository), typeof(BroadcastRepository));

            FileConstant.ImagePath = Path.Combine(_env.WebRootPath, "assets", "img");

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            await app.Seed();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                 );
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<BroadcastHub>("/broHub");
            });
        }
    }
}
