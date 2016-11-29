using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestType
    {
        public TestType()
        {
            AssayTypeTest = new HashSet<AssayTypeTest>();
            Test = new HashSet<Test>();
            TestTypeMaterials = new HashSet<TestTypeMaterials>();
        }

        public int TestTypeId { get; set; }
        public string TestName { get; set; }
        public string TestTypeDescription { get; set; }
        public double? DaysToComplete { get; set; }
        public double? TestTypePrice { get; set; }

        public virtual ICollection<AssayTypeTest> AssayTypeTest { get; set; }
        public virtual ICollection<Test> Test { get; set; }
        public virtual ICollection<TestTypeMaterials> TestTypeMaterials { get; set; }
    }
}
