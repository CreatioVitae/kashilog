using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace WebApi.Kashilog {
    public static class StartupExtensionLibrary {
        internal static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration) {
            //Todo:ConfigurationConfig

            //Todo:Controllers

            //SqlManager
            services.AddSqlManager(configuration[$"kashilogDatabaseConfig:connectionString"]);

            //Services,Repositories
            services.AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes());

            // HttpClientFactory

            //Logger.

            return services;
        }
    }
}
