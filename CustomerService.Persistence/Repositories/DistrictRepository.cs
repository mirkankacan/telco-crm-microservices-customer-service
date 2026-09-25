using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class DistrictRepository : EfRepositoryBase<District, short, CustomerDbContext>, IDistrictRepository
    {
        public DistrictRepository(CustomerDbContext context) : base(context)
        {
        }

    }
}
