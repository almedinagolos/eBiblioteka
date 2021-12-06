using eBiblioteka.DB;
using eBiblioteka.Filters;
using eBiblioteka.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka
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
            services.AddDbContext<MojDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("cs1")));

            services.AddSwaggerGen();
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IBibliotekaService, BibliotekaService>();
            services.AddScoped<IZaposlenikService, ZaposlenikService>();
            services.AddScoped<IClanService, ClanService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<IVrsteBibliotekaService, VrsteBibliotekaService>();
            services.AddScoped<IDrzavaService, DrzavaService>();
            services.AddScoped<IPisacService, PisacService>();
            services.AddScoped<IUlogaService, UlogaService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


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
