using Autofac;
using AutoMapper;
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
using Newtonsoft.Json.Serialization;
using Project.DAL;
using Project.Service.Dependency;
using Project.WebAPI.Dependency;
using Project.WebAPI.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WebAPI
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
            services.AddControllers()
               .AddNewtonsoftJson(options => {
                   options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
               });

            services.AddDbContext<VehicleContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("VehicleConnection")));

            //services.AddScoped<IVehicleMakeService, VehicleMakeService>();

            services.AddOptions();
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile(new ModelProfile());
                c.AddProfile(new MakeProfile());
                c.AddProfile(new Project.Service.Profiles.MakeProfile());
                c.AddProfile(new Project.Service.Profiles.ModelProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DependencyRegister());
            var container = ContainerConfig.Configure();
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
