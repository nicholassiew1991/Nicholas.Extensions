using Microsoft.Extensions.DependencyInjection;

namespace Nicholas.Extensions.DependencyInjection.ServiceModule
{
    public interface IServiceModule
    {
        void Register(IServiceCollection services);
    }
}