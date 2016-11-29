using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class OrderCharges
    {
        public int OrderId { get; set; }
        public int OrderSequence { get; set; }
        public int TestId { get; set; }
        public double? ChargeCost { get; set; }
        public DateTime? ChargeDate { get; set; }

        public virtual Test Test { get; set; }
    }
}
