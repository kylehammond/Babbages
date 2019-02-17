namespace KSH.Babbages.Entities
{
    public class PayStubItem : BaseEntity
    {
        public PayStubItemType Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}