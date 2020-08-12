using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hepsiSefBlog.Data.Context;
using hepsiSefBlog.Data.Context.Repos;
using hepsiSefBlog.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace hepsiSefBlog
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(opt => 
            {
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddControllers();
            services.AddScoped<RecipeRepository>();
            services.AddTransient<RecipeService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("", new OpenApiInfo { 
                    Version = "v1",
                    Title = "HepsiSef API",
                    Description = "HepsiSef com için tasarlanan api"
                });

            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.jon", "HepsiSef API v1 test");
                c.RoutePrefix = string.Empty;
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute("default","api/{controller=Recipes}/{action=GetAll}");
            });
        }
    }
}
