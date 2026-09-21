using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerService.Persistence.EntityTypeConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.ToTable("individual_customers");
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.NationalIdentity)
            .IsRequired()
            .HasMaxLength(11)
            .IsFixedLength();

        builder.HasIndex(x => x.NationalIdentity)
            .IsUnique();

        builder.Property(x => x.BirthDate)
            .IsRequired()
            .HasColumnType("date");
    }
}
