using System.Data.Entity.ModelConfiguration;
using KSH.Babbages.Entities;

namespace KSH.Babbages.Data.Configurations
{
    public class AccountEntityConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountEntityConfiguration()
        {
            HasRequired(a => a.FinancialInstitution)
                .WithMany(f => f.Accounts);
        }
    }
}