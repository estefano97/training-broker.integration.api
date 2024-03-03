using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using training_broker.integration.handler.mapper;

namespace training_broker.integration.handler
{
    public static class HandlerServiceRegistration
    {
        public static IServiceCollection AddInHandlerServices(this IServiceCollection services, IConfiguration configuration)
        {
            //AUTOMAPPER CONFIGURATION
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //MEDIATOR CONFIGURATION
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining(typeof(HandlerServiceRegistration)));

            return services;
        }
    }
}
