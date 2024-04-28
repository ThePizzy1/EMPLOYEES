using EMPLOYEES.DAL.DataModel;
using EMPLOYEES.Repository;
using EMPLOYEES.Repository.Common;
using EMPLOYEES.Sevice.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMPLOYEES.WebAPI
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
            services.AddDbContext<EMPLOYEES_DbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("EMPLOYEES_DBConnection")));
            services.AddScoped<IService, Service.Service>();
            services.AddScoped<IRepository, Repository.Repository>();
            services.AddScoped<IRepositoryMappingService, RepositoryMappingService>();
            services.AddCors();
            services.AddControllers();
        }


      
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
