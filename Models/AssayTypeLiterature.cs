using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class AssayTypeLiterature
    {
        public int AssayTypeId { get; set; }
        public int LiteratureId { get; set; }

        public virtual AssayType AssayType { get; set; }
        public virtual Literature Literature { get; set; }
    }
}
