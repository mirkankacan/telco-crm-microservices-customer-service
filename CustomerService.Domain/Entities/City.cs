using Core.Domain;

namespace CustomerService.Domain.Entities
{
    public class City : BaseEntity<short>
    {
        public string Name { get; set; }
        public virtual ICollection<District> Districts { get; set; } = new HashSet<District>();
        public City()
        {
        }
        public City(short id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
