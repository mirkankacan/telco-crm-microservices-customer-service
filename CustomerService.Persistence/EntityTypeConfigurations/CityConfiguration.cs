using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerService.Persistence.EntityTypeConfigurations;

public class CityConfiguration : BaseEntityTypeConfiguration<City, short>
{
    protected override void ConfigureEntity(EntityTypeBuilder<City> builder)
    {

        builder.Property(x => x.Id)
            .ValueGeneratedNever();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(x => x.Name)
            .IsUnique();
    }
}
