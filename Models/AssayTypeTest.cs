using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class AssayTypeTest
    {
        public int AssayTypeId { get; set; }
        public int TestSequence { get; set; }
        public bool? Required { get; set; }

        public virtual AssayType AssayType { get; set; }
    }
}
