using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface IAddressRepository : IAsyncRepository<Address, Guid>, IRepository<Address, Guid>
    {
    }
}
