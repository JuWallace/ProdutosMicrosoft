using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoAgendaMedica_Web.Dal;
using ProjetoAgendaMedica_Web.Models;
using ProjetoAgendaMedica_Web.Utils;

namespace ProjetoAgendaMedica_Web
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
            services.AddScoped<UsuarioDAO>();
            services.AddScoped<MedicoDAO>();
            services.AddScoped<PacienteDAO>();
            services.AddScoped<PlanoSaudeDAO>();
            services.AddScoped<ConsultaDAO>();
            services.AddScoped<ProntuarioDAO>();

            services.AddTransient<IEmailSender, EmailSender>();

            services.AddDbContext<Context>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("connection")));

            services.AddIdentity<Usuario, IdentityRole>()
                .AddEntityFrameworkStores<Context>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Usuario/Login";
                options.AccessDeniedPath = "/Usuario/AcessoNegado";
            });

            services.AddControllersWithViews().AddNewtonsoftJson(
                options => options.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

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
