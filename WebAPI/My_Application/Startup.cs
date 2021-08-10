using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using FluentValidation;
using FluentValidation.AspNetCore;
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

namespace My_Application
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
                .AddRazorRuntimeCompilation()
                .AddFluentValidation();

            #region Fluent Validation
            services.AddTransient<IValidator<ViewModels.TestModelVM>, Validator.TestModelValidation>();
            #endregion

            services.AddTransient<Data.IUnitOfWork, Data.UnitOfWork>(sp =>
         {
             Data.Tools.Options options =
                 new Data.Tools.Options
                 {
                     Provider =
                         (Data.Tools.Enums.Provider)
                         System.Convert.ToInt32(Configuration.GetSection(key: "databaseProvider").Value),

                     //using Microsoft.EntityFrameworkCore;
                     //  ConnectionString =
                     //  	Configuration.GetConnectionString().GetSection(key: "MyConnectionString").Value,

                     ConnectionString =
                         Configuration.GetSection(key: "ConnectionStrings").GetSection(key: "MyConnectionString").Value,
                 };

             return new Data.UnitOfWork(options: options);
         });


            #region Db Context
            services.AddDbContext<DatabaseContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));
            #endregion

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My_Application", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My_Application v1"));
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