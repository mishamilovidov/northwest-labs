using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class AssayType
    {
        public AssayType()
        {
            Assay = new HashSet<Assay>();
            AssayTypeLiterature = new HashSet<AssayTypeLiterature>();
            AssayTypeTest = new HashSet<AssayTypeTest>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int AssayTypeId { get; set; }
        public string AssayTypeName { get; set; }
        public string AssayTypeDescription { get; set; }
        public double? MinCost { get; set; }
        public double? MaxCost { get; set; }

        public virtual ICollection<Assay> Assay { get; set; }
        public virtual ICollection<AssayTypeLiterature> AssayTypeLiterature { get; set; }
        public virtual ICollection<AssayTypeTest> AssayTypeTest { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
