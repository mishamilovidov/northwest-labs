using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Literature
    {
        public Literature()
        {
            TestTypeLiterature = new HashSet<TestTypeLiterature>();
        }

        public int LiteratureId { get; set; }
        public string LiteratureDescription { get; set; }

        public virtual ICollection<TestTypeLiterature> TestTypeLiterature { get; set; }
    }
}
