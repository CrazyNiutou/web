using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NT.Business;
using NT.IBusiness;
using NT.ICommon;
using NT.Models;
using NT.Web.Models;

namespace NT.Web
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
            services.AddOptions();
            services.Configure<ConfigOptions>(Configuration.GetSection("ConfigOptions"));
            services.AddMvc();
            //添加授权
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = "MyCookieMiddleware";
                options.DefaultSignInScheme = "MyCookieMiddleware";
                options.DefaultAuthenticateScheme = "MyCookieMiddleware";
            }).AddCookie("MyCookieMiddleware", options =>
             {
                 options.LoginPath = new PathString("/account/index/");
                 options.AccessDeniedPath = new PathString("/account/index/");
                 //options.LogoutPath = new PathString("/Account/index");
             });

            #region 自定义注入

            services.AddScoped<MySqlOperator>();
            services.AddDbStoreHolder();
            services.AddScoped<IAccount, Account>();
            services.AddScoped<OutputParam>();
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/home/error");
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //调用身份验证中间件
            app.UseAuthentication();
            app.UseStaticFiles();
        }
    }
}
