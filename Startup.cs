using Colomb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colomb.Configurations;
using Colomb.IRepository;
using Colomb.Repository;

namespace Colomb
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

            // Database
            services.AddDbContext<DatabaseContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("sqlConnection"))
            );


            // CORS Configuration
            // Who is allowed to access this API, what methods are available and what headers must the user have
            services.AddCors(o => {
                o.AddPolicy("AllowAll", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

            /* Auto Mapper */
            services.AddAutoMapper(typeof(MapperInitializer));

            /* Register IUnitOfWork */
            // AddTransient - provide a fresh copy every time a client contacts the server
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            /* Swagger */
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Colomb", Version = "v1" });
            });

            /* Controllers */
            // NewSoft => Ignore some Loop Reference Warnings
            services.AddControllers(
            /* config => {
                config.CacheProfiles.Add("120SecondsDuration", new CacheProfile
                {
                    Duration = 120
                });
            }*/
                ).AddNewtonsoftJson(op =>
                op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
             /* Swagger */
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Colomb v1"));

            // CORS POLICY, user specific Policy we defined in ConfigureServices
            app.UseCors("AllowAll");

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
