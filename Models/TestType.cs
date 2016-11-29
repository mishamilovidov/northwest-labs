using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestType
    {
        public TestType()
        {
            Test = new HashSet<Test>();
            TestTypeLiterature = new HashSet<TestTypeLiterature>();
            TestTypeMaterials = new HashSet<TestTypeMaterials>();
        }

        public int TestTypeId { get; set; }
        public string TestName { get; set; }
        public string TestTypeDescription { get; set; }
        public double? DaysToComplete { get; set; }
        public double? TestTypePrice { get; set; }

        public virtual ICollection<Test> Test { get; set; }
        public virtual ICollection<TestTypeLiterature> TestTypeLiterature { get; set; }
        public virtual ICollection<TestTypeMaterials> TestTypeMaterials { get; set; }
    }
}
