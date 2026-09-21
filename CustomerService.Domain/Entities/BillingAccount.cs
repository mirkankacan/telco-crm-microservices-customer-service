using Core.Domain;
using CustomerService.Domain.Enums;

namespace CustomerService.Domain.Entities
{
    public class BillingAccount : BaseEntity<Guid>
    {
        public Guid CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public BillingAccountType Type { get; set; }
        public BillingAccountStatus Status { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address Address { get; set; }
        public BillingAccount()
        {

        }

        public BillingAccount(Guid id, Guid customerId, Guid addressId, string name, string number, string description, BillingAccountType type, BillingAccountStatus status)
        {
            Id = id;
            CustomerId = customerId;
            AddressId = addressId;
            Name = name;
            Number = number;
            Description = description;
            Type = type;
            Status = status;

        }
    }
}
