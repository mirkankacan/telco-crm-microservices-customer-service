using Core.Domain;

namespace CustomerService.Domain.Entities
{
    public class Customer : BaseEntity<Guid>
    {
        public string Number { get; set; }
        public virtual ICollection<BillingAccount> BillingAccounts { get; set; } = new HashSet<BillingAccount>();
        public Customer()
        {

        }
    }
}
