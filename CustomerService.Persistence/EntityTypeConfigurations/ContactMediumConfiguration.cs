using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerService.Persistence.EntityTypeConfigurations;

public class ContactMediumConfiguration : BaseEntityTypeConfiguration<ContactMedium, Guid>
{
    protected override void ConfigureEntity(EntityTypeBuilder<ContactMedium> builder)
    {

        builder.Property(x => x.Value)
            .IsRequired()
            .HasMaxLength(320);

        builder.HasOne(x => x.Customer)
            .WithMany()
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(x => x.CustomerId);
    }
}
