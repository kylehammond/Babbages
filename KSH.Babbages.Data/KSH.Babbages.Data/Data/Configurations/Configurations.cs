using System.Data.Entity.ModelConfiguration;
using KSH.Babbages.Entities;

namespace KSH.Babbages.Data.Configurations
{
    public class AccountEntityConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountEntityConfiguration()
        {
            
        }
    }

    public class AllocationEntityConfiguration : EntityTypeConfiguration<Allocation>
    {
        public AllocationEntityConfiguration()
        {

        }
    }

    public class AssumptionEntityConfiguration : EntityTypeConfiguration<Account>
    {
        public AssumptionEntityConfiguration()
        {

        }
    }

    public class FinancialInstitutionEntityConfiguration : EntityTypeConfiguration<FinancialInstitution>
    {
        public FinancialInstitutionEntityConfiguration()
        {

        }
    }

    public class PayStubEntityConfiguration : EntityTypeConfiguration<PayStub>
    {
        public PayStubEntityConfiguration()
        {

        }
    }

    public class PayStubItemEntityConfiguration : EntityTypeConfiguration<PayStubItem>
    {
        public PayStubItemEntityConfiguration()
        {

        }
    }

    public class PersonEntityConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonEntityConfiguration()
        {

        }
    }
}
