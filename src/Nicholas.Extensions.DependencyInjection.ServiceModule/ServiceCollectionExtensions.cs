using System;
using Nicholas.Extensions.DependencyInjection.ServiceModule;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServiceModule<T>(this IServiceCollection services) where T : class, IServiceModule
        {
            IServiceModule serviceModule = Activator.CreateInstance<T>();
            return services.RegisterServiceModule(serviceModule);
        }
        
        public static IServiceCollection RegisterServiceModule(this IServiceCollection services, IServiceModule serviceModule)
        {
            serviceModule.Register(services);
            return services;
        }
    }
}