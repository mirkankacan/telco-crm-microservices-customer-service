using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface IIndividualCustomerRepository : IAsyncRepository<IndividualCustomer, Guid>, IRepository<IndividualCustomer, Guid>
    {
    }
}
