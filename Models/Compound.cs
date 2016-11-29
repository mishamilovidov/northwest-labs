using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Compound
    {
        public Compound()
        {
            CompoundReceipt = new HashSet<CompoundReceipt>();
        }

        public int Ltnumber { get; set; }
        public string CompoundName { get; set; }
        public int OrderId { get; set; }

        public virtual ICollection<CompoundReceipt> CompoundReceipt { get; set; }
        public virtual Orders Order { get; set; }
    }
}
