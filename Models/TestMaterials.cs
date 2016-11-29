using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestMaterials
    {
        public int TestId { get; set; }
        public int MaterialId { get; set; }
        public double? MaterialUsed { get; set; }

        public virtual Materials Material { get; set; }
        public virtual Test Test { get; set; }
    }
}
