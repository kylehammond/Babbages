using System;

namespace KSH.Babbages.Entities
{
    public class Allocation : BaseEntity
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public DateTime Due { get; set; }
        public string Frequency { get; set; }
    }
}