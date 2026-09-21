using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface ICityRepository : IAsyncRepository<City, short>, IRepository<City, short>
    {
    }
}
