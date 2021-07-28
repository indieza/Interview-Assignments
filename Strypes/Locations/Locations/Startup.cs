// <copyright file="Startup.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations
{
    using Locations.Services.CreateLocation;
    using Locations.Services.GetLocation;
    using Locations.Services.PatchLocation;
    using Locations.Services.PutChargePoint;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc();

            services.AddDbContext<LocationsDbContext>(options =>
                options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<ICreateLocationService, CreateLocationService>();
            services.AddTransient<IPatchLocationService, PatchLocationService>();
            services.AddTransient<IGetLocationService, GetLocationService>();
            services.AddTransient<IPutChargePointService, PutChargePointService>();
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