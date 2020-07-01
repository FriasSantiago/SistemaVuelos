using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaAerolinea.Context;
using SistemaAerolinea.Models;

namespace SistemaAerolinea
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
            services.AddMvc();
            
            // Conecta con la BBDD
            services.AddDbContext<AerolineaDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("AerolineaDbContext")));
            
            // Agrega Identity y lo relaciona con EFCore
            services.AddIdentity<Usuario, IdentityRole>().AddEntityFrameworkStores<AerolineaDbContext>();
            services.Configure<IdentityOptions>(options =>{
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            // Permite DI para el repositorio de vuelos
            services.AddTransient<IRepoVuelos, RepoVuelos>();
            services.AddTransient<IRepoReservas, RepoReservas>();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                Console.WriteLine("Dev");
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("Home/Error");
            }

            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Autenticacion y autorizacion
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
