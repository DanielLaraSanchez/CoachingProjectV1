using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataLayer.Entities.DataManager;
using DataLayer.Entities.Repository;

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
            services.AddDbContext<PoolChampionContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:PoolChampionDB"]));
            services.AddScoped<IDataRepository<Game>, GameManager>();//IS THIS CREATING THE DEPENDENCY CONTAINER?
            services.AddScoped<IDataRepository<Player>, PlayerManager>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
