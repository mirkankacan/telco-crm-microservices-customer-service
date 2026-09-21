using CustomerService.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerService.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomerDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("CustomerDbConnection"), npgsql =>
                {
                    npgsql.MigrationsAssembly(typeof(CustomerDbContext).Assembly.FullName);
                }).UseSnakeCaseNamingConvention());
            return services;
        }
    }
}
