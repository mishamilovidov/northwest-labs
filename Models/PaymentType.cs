using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Payments = new HashSet<Payments>();
        }

        public int PaymentTypeId { get; set; }
        public string PaymentDescription { get; set; }

        public virtual ICollection<Payments> Payments { get; set; }
    }
}
