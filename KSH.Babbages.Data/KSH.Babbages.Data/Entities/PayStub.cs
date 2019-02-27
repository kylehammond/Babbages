using System.Collections.Generic;

namespace KSH.Babbages.Entities
{
    public class PayStub : BaseEntity
    {
        public Person Payee { get; set; }
        public ICollection<PayStubItem> Items { get; set; }
    }
}