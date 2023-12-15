using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvansProjeClient.ApiService.AuthApiService;
using AvansProjeClient.ApiService.WorkerAPIService;
using AvansProjeClient.BLL.Abstract;
using AvansProjeClient.BLL.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AvansProjeClient.UI
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

            services.AddScoped<IWorkerBLL, WorkerBLL>();
            services.AddScoped<IAuthBLL, AuthBLL>();

            services.AddHttpClient<WorkerService>(conf =>
            {
                conf.BaseAddress = new Uri(Configuration["myBaseUri"]);
            });
            services.AddHttpClient<AuthService>(conf =>
            {
                conf.BaseAddress = new Uri(Configuration["myBaseUri"]);
            });

            services.AddAuthentication(a =>
            {
                a.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                a.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                a.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;

            }).AddCookie(a =>
            {
                a.LoginPath = "/Auth/Login";
                a.AccessDeniedPath = "/Auth/Login";
                a.Cookie.Name = CookieAuthenticationDefaults.AuthenticationScheme;
                a.Cookie.HttpOnly = true;
            });
            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("Admin", policy =>
                {
                    policy.RequireRole("Admin");
                });
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
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Auth}/{action=Login}/{id?}");
            });
        }
    }
}
