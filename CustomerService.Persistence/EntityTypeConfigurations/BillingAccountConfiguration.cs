using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerService.Persistence.EntityTypeConfigurations;

public class BillingAccountConfiguration : BaseEntityTypeConfiguration<BillingAccount, Guid>
{
    protected override void ConfigureEntity(EntityTypeBuilder<BillingAccount> builder)
    {

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Number)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(x => x.Number)
            .IsUnique();

        builder.Property(x => x.Description)
            .HasMaxLength(500);

        builder.HasOne(x => x.Customer)
            .WithMany(x => x.BillingAccounts)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Address)
            .WithMany(x => x.BillingAccounts)
            .HasForeignKey(x => x.AddressId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
