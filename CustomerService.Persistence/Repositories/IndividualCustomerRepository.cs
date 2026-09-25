using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class IndividualCustomerRepository : EfRepositoryBase<IndividualCustomer, Guid, CustomerDbContext>, IIndividualCustomerRepository
    {
        public IndividualCustomerRepository(CustomerDbContext context) : base(context)
        {
        }

    }
}
