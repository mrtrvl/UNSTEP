﻿namespace UNSTEP.API
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using SchoolAdmin.Data;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Add application services
            services.AddSingleton<ISchoolRepository>(new MockSchoolRepository());

            services.AddMvc(
                setupAction => { setupAction.ReturnHttpNotAcceptable = true; });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(
                    appBuilder =>
                        {
                            appBuilder.Run(
                                async context =>
                                    {
                                        context.Response.StatusCode = 500;
                                        await context.Response.WriteAsync(
                                            "An unexpected fault happened. Please try again later or contact our support if issue persists");
                                    });
                        });
            }

            app.UseMvc();
        }
    }
}
