using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface IContactMediumRepository : IAsyncRepository<ContactMedium, Guid>, IRepository<ContactMedium, Guid>
    {
    }
}
