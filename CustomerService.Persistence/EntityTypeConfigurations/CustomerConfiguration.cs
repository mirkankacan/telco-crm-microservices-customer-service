using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerService.Persistence.EntityTypeConfigurations;

public class CustomerConfiguration : BaseEntityTypeConfiguration<Customer, Guid>
{
    protected override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.Number)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(x => x.Number)
            .IsUnique();


    }
}
