using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface IBillingAccountRepository : IAsyncRepository<BillingAccount, Guid>, IRepository<BillingAccount, Guid>
    {
    }
}
