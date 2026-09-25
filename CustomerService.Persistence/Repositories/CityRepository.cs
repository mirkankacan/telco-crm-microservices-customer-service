using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class CityRepository : EfRepositoryBase<City, short, CustomerDbContext>, ICityRepository
    {
        public CityRepository(CustomerDbContext context) : base(context)
        {
        }

    }
}
