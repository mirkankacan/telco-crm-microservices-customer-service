using Microsoft.Extensions.DependencyInjection;

namespace CustomerService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {

            return services;
        }
    }
}
