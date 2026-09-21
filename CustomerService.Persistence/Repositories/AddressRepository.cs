using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class AddressRepository : EfRepositoryBase<Address, Guid, CustomerDbContext>, IAddressRepository
    {
        public AddressRepository(CustomerDbContext context) : base(context)
        {
        }


    }
}
