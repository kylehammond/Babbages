using System.Data.Entity;
using KSH.Babbages.Data.Configurations;
using KSH.Babbages.Entities;

namespace KSH.Babbages.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<Assumption> Assumptions { get; set; }
        public DbSet<FinancialInstitution> FinancialInstitutions { get; set; }
        public DbSet<PayStub> PayStubs { get; set; }
        public DbSet<PayStubItem> PayStubItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountEntityConfiguration());
            modelBuilder.Configurations.Add(new AllocationEntityConfiguration());
            modelBuilder.Configurations.Add(new AssumptionEntityConfiguration());
            modelBuilder.Configurations.Add(new FinancialInstitutionEntityConfiguration());
            modelBuilder.Configurations.Add(new PayStubEntityConfiguration());
            modelBuilder.Configurations.Add(new PayStubItemEntityConfiguration());
            modelBuilder.Configurations.Add(new PersonEntityConfiguration());
        }
    }
}
