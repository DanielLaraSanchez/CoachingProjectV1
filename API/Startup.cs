using DataLayer;
using DataLayer.Entities;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //what the fuck is a script?
        //what is it that connects the entities to the domain?

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PoolChampionContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("PoolChampionDB")));

            //services.AddDbContext<PoolChampionContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:PoolChampionDB"]));
            //services.AddScoped<IPlayerRepository<Game>, PlayerRepository>();//IS THIS CREATING THE DEPENDENCY CONTAINER?
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IPoolChampionService, PoolChampionService>();
            services.AddSpaStaticFiles(c =>
            {
                c.RootPath = "poolchampionUI/dist";
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSpaStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller}/{action=index}/{id}");
            });
            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501
                spa.Options.SourcePath = "..\\poolchampionUI";
                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            }); 
        }
    }
}
