using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WhoozatAPI.Dtos;
using WhoozatAPI.Entities;
using WhoozatAPI.Middlewares;
using WhoozatAPI.Repositories;
using WhoozatAPI.Services;

namespace WhoozatAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            //Configuration = configuration;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();

            Configuration = builder.Build();

            Debug.WriteLine($" ---> From Config: {Configuration["Author"]}");
            Debug.WriteLine($" ---> From Config: {Configuration["Logging:Debug:LogLevel:Default"]}");
        }

        //public Startup(IHostingEnvironment env)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json");

        //    Configuration = builder.Build();

        //    Debug.WriteLine($" ---> From Config: {Configuration["Logging"]}");
        //}
        
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<WhoozatConfiguration>(Configuration);
            var sqlConnectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<WhoozatDBContext>(options =>
                options.UseMySql(sqlConnectionString, b => b.MigrationsAssembly("WhoozatAPI")));
            services.AddScoped<IEstateRepository, EstateRepository>();
            services.AddScoped<ISeedDataService, SeedDataService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCustomMiddleware();
            }

            if (env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
                app.UseCustomMiddleware();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            AutoMapper.Mapper.Initialize(mapper => 
            {
                mapper.CreateMap<Estate, EstateDto>().ReverseMap();
            });

            app.AddSeedData();

            app.UseMvc();
        }
    }
}
