using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class BillingAccountRepository : EfRepositoryBase<BillingAccount, Guid, CustomerDbContext>, IBillingAccountRepository
    {
        public BillingAccountRepository(CustomerDbContext context) : base(context)
        {
        }

    }
}
