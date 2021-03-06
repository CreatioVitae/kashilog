using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using WebApi.Kashilog.ConstantValues.Kashi;
using WebApi.Kashilog.Repositories.DatabaseConnections;

namespace WebApi.Kashilog {
    public static class StartupExtensionLibrary {
        internal static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services, IConfiguration configuration) {
            //SqlManager<TDatabaseConnection>
            services
                .AddSqlManager<KashilogConnection>((connectionName: DatabaseNameResource.KashilogDatabase, connectionString: configuration[$"kashilogDatabaseConfig:connectionString"]))
                .AddSqlManager<AccountConnection>((connectionName: DatabaseNameResource.AccountDatabase, connectionString: configuration[$"accountDatabaseConfig:connectionString"]));

            //Services,Repositories
            services.AddDefaultScopedServices(Assembly.GetExecutingAssembly().GetTypes());

            // HttpClientFactory

            //Logger.

            return services;
        }
    }
}
