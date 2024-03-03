using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using training_broker.integration.infrastructure.Database;

namespace training_broker.integration.infrastructure
{
    public static class InfrastructureServiceRegistration
    {

        public static IServiceCollection AddInInfrestructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IEstadosReporte, EstadosReporteService>();
            services.AddSingleton<TrainingBrokerContext>();
            return services;
        }

    }
}
