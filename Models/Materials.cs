using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Materials
    {
        public Materials()
        {
            TestMaterials = new HashSet<TestMaterials>();
            TestTypeMaterials = new HashSet<TestTypeMaterials>();
        }

        public int MaterialId { get; set; }
        public string MaterialDescription { get; set; }
        public double? MaterialCost { get; set; }

        public virtual ICollection<TestMaterials> TestMaterials { get; set; }
        public virtual ICollection<TestTypeMaterials> TestTypeMaterials { get; set; }
    }
}
