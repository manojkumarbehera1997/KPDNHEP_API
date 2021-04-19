using KPDNHEP.Console.Application.Services;
using KPDNHEP.Console.Data;
using KPDNHEP.Console.Data.Repositories;
using KPDNHEP.Console.Domain.Repositories;
using KPDNHEP.Console.Domain.Services;
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

namespace KPDNHEP.Console.API
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
            services.AddCors(Options => Options.AddPolicy("AllowAll", p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KPDNHEP.Console.API", Version = "v1" });
            });
            services.AddTransient<IApplicationService, ApplicationService>();
            services.AddTransient<ISettingService, SettingService>();
            services.AddTransient<IAssignApplicationService, AssignApplicationService>();
            services.AddTransient<IUserGroupService, UserGroupService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserGroupApplicationService, UserGroupApplicationService>();
            services.AddTransient<IApplicationRepository, ApplicationRepository>();           
            services.AddTransient<ISettingRepository, SettingRepository>();            
            services.AddTransient<IAssignApplicationRepository, AssignApplicationRepository>();           
            services.AddTransient<IUserGroupRepository, UserGroupRepository>();
            services.AddTransient<IUserGroupApplicationRepository, UserGroupApplicationRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "KPDNHEP.Console.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AllowAll");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
