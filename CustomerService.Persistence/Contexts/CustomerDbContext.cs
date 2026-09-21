using Core.Persistence.Contexts;
using CustomerService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CustomerService.Persistence.Contexts
{
    public class CustomerDbContext : EfDbContextBase
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BillingAccount> BillingAccounts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ContactMedium> ContactMediums { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
