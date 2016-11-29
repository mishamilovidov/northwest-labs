using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestTypeLiterature
    {
        public int TestTypeId { get; set; }
        public int LiteratureId { get; set; }

        public virtual Literature Literature { get; set; }
        public virtual TestType TestType { get; set; }
    }
}
