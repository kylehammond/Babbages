using System.Collections.Generic;

namespace KSH.Babbages.Entities
{
    public class PayStub : BaseEntity
    {
        public Person Payee { get; set; }
        public List<PayStubItem> Items { get; set; }
    }
}