using Core.Persistence.Repositories.EfCore;
using CustomerService.Application.Repositories;
using CustomerService.Domain.Entities;
using CustomerService.Persistence.Contexts;

namespace CustomerService.Persistence.Repositories
{
    public class ContactMediumRepository : EfRepositoryBase<ContactMedium, Guid, CustomerDbContext>, IContactMediumRepository
    {
        public ContactMediumRepository(CustomerDbContext context) : base(context)
        {
        }

    }
}
