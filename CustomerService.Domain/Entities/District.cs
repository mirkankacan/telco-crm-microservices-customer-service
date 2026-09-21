using Core.Domain;

namespace CustomerService.Domain.Entities
{
    public class District : BaseEntity<short>
    {
        public string Name { get; set; }
        public short CityId { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public District()
        {

        }
        public District(short id, string name, short cityId)
        {
            Id = id;
            Name = name;
            CityId = cityId;
        }
    }
}
