using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Literature
    {
        public Literature()
        {
            AssayTypeLiterature = new HashSet<AssayTypeLiterature>();
        }

        public int LiteratureId { get; set; }
        public string LiteratureDescription { get; set; }

        public virtual ICollection<AssayTypeLiterature> AssayTypeLiterature { get; set; }
    }
}
