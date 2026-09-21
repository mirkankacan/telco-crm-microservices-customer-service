using Core.Abstractions.Repositories;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Repositories
{
    public interface IDistrictRepository : IAsyncRepository<District, short>, IRepository<District, short>
    {
    }
}
