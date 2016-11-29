using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Assay
    {
        public Assay()
        {
            CompoundReceipt = new HashSet<CompoundReceipt>();
            Test = new HashSet<Test>();
        }

        public int AssayId { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
        public int AssayTypeId { get; set; }

        public virtual ICollection<CompoundReceipt> CompoundReceipt { get; set; }
        public virtual ICollection<Test> Test { get; set; }
        public virtual AssayType AssayType { get; set; }
    }
}
