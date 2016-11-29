using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class CompoundReceipt
    {
        public int Ltnumber { get; set; }
        public int CompoundSequenceCode { get; set; }
        public double? Quantity { get; set; }
        public DateTime? DateArrived { get; set; }
        public int ReceivedByEmpId { get; set; }
        public DateTime? DateDue { get; set; }
        public string Appearance { get; set; }
        public double? WeightClient { get; set; }
        public double? MolecularMass { get; set; }
        public double? ActualWeight { get; set; }
        public double? MaximumToleratedDose { get; set; }
        public int? AssayId { get; set; }

        public virtual Assay Assay { get; set; }
        public virtual Compound LtnumberNavigation { get; set; }
        public virtual Employee ReceivedByEmp { get; set; }
    }
}
