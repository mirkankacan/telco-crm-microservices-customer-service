using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface ICustomerRepository : IAsyncRepository<Customer, Guid>, IRepository<Customer, Guid>
    {
    }
}
