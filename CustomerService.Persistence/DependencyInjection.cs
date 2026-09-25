using CustomerService.Application.Repositories;
using CustomerService.Persistence.Contexts;
using CustomerService.Persistence.Repositories;
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
            AddRepositories(services);
            return services;
        }
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<IContactMediumRepository, ContactMediumRepository>();
            services.AddScoped<IBillingAccountRepository, BillingAccountRepository>();
            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IIndividualCustomerRepository, IndividualCustomerRepository>();
        }
    }
}
