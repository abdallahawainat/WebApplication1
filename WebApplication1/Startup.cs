using learn.core.domain;
using learn.core.Repository;
using learn.core.service;
using learn.infra.domain;
using learn.infra.Repository;
using learn.infra.service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
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
            services.AddScoped<IDBcontext, DBcontext>();
         
            services.AddScoped<Idep_apirepository, dep_apirepository>();
            services.AddScoped<Iemployee_apirepository, employee_apirepository>();
            services.AddScoped<Itask_apirepository, task_apirepository>();
            services.AddScoped<Iemptaskrepository, emptaskrepository>();
            services.AddScoped<Iempinfo_dtorepository, empinfo_dtorepository>();
           
            services.AddScoped<Idep_apiservice, dep_apiservice>();
            services.AddScoped<Iemployee_apiservice, employee_apiservice>();
            services.AddScoped<Itask_apiservice, task_apiservice>();
            services.AddScoped<Iemptaskservice, emptaskservice>();
            services.AddScoped<Iempinfo_dtoservice, empinfo_dtoservice>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
