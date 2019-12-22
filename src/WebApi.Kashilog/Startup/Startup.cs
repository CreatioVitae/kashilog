using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swagger.Extensions.DependencyInjection.Configurations;

namespace WebApi.Kashilog {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services
                .AddDefaultSwaggerService(Configuration.GetSection(nameof(SwaggerDocSettings)).Get<SwaggerDocSettings>())
                .ConfigureDependencyInjection(Configuration).CreateDefaultBuilder();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app
                .UseDefaultSwaggerBuilder(Configuration.GetSection(nameof(SwaggerUiSettings)).Get<SwaggerUiSettings>(), env.EnvironmentName)
                .UseDefaultBuilder(env.EnvironmentName);

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}