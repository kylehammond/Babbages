using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace KSH.Babbages.Entities
{
    public class FinancialInstitution : BaseEntity
    {
        public string Name { get; set; }
        public string BrandPrimaryColor { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
