using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Payments
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int PaymentTypeId { get; set; }
        public double? PaymentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }

        public virtual Orders Order { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
