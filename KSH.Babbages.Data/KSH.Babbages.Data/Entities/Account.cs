namespace KSH.Babbages.Entities
{
    public class Account : BaseEntity
    {
        public Person PrimaryAccountHolder { get; set; }
        public Person JointAccountHolder { get; set; }
        public FinancialInstitution FinancialInstitution { get; set; }
    }
}