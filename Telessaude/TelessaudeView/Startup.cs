using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelessaudeData.Contexts;
using TelessaudeData.Repositories.Interfaces;
using TelessaudeData.Models;
using TelessaudeData.Repositories;
using TelessaudeViewModel.Services;
using TelessaudeViewModel.Services.Interfaces;
using TelessaudeView.Utils;

namespace TelessaudeView
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
           // services.AddControllersWithViews();
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddEntityFrameworkSqlServer().AddDbContext<TelessaudeContext>();
            services.AddDbContext<TelessaudeContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Connectionstring"));
            });
            services.AddTransient<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            services.AddTransient<IBaseService<Paciente>, BaseService<Paciente>>();
            services.AddTransient<IPacienteService, PacienteService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
