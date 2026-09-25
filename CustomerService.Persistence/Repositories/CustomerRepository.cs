using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class CustomerRepository : EfRepositoryBase<Customer, Guid, CustomerDbContext>, ICustomerRepository
    {
        public CustomerRepository(CustomerDbContext context) : base(context)
        {
        }

    }
}
