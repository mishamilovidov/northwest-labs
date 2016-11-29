using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestTypeMaterials
    {
        public int TestTypeId { get; set; }
        public int MaterialId { get; set; }

        public virtual Materials Material { get; set; }
        public virtual TestType TestType { get; set; }
    }
}
