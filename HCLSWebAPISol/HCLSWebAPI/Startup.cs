using HCLSWebAPI.DataAccess.IRepository;
using HCLSWebAPI.DataAccess.Repository;
using HCLSWebAPI.DataBaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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

namespace HCLSWebAPI
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
            services.AddCors();
            services.AddSwaggerGen();
            services.AddControllers();
            services.AddDbContext<HCLSContextPro>(options => options.UseSqlServer(Configuration.GetConnectionString("ConStr")));
            services.AddTransient<IAdmtypRepository,AdmtypRepository>();
            services.AddTransient<IAdmRepository,AdmRepository>();
            services.AddTransient<IDeptRepository, DeptRepository>();
            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<IDoctorSpecRepository, DoctorSpecRepository>();
            services.AddTransient<IHelpRepository, HelpRepository>();
            services.AddTransient<ILabRepository, LabRepository>();
            services.AddTransient<IReceptionRepository, ReceptionRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        
            app.UseCors(builder =>
            {
               builder
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();

              });


            app.UseRouting();

            

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Web API Pro");
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
