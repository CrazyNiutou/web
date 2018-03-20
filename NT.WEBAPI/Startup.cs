using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NT.Business;
using NT.Common;
using NT.IBusiness;
using NT.ICommon;
using NT.Models;
using System.Text;

namespace NT.WEBAPI
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
            //添加Jwt验证
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option => option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidAudience = "test.com",
                ValidIssuer = "test.com",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dd%88*377f6d&f£$$£$FdddFF33fssDG^!3"))
            });
            services.AddMvc();
            services.AddCors(options => options.AddPolicy("CorsCore", x => x.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:8080")));
            //自定义注入
            services.Configure<ConfigOptions>(Configuration.GetSection("ConfigOptions"));
            services.AddScoped<MySqlOperator>();
            services.AddSingleton<IDbStoreHolder, DbStoreHolder>();
            services.AddScoped<IAccount, Account>();
            services.AddLogging();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseCors("CorsCore");
            
        }
    }
}