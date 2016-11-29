using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Test
    {
        public Test()
        {
            OrderCharges = new HashSet<OrderCharges>();
            TestEmployee = new HashSet<TestEmployee>();
            TestMaterials = new HashSet<TestMaterials>();
        }

        public int TestId { get; set; }
        public int AssayId { get; set; }
        public int TestTypeId { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
        public double? Concentration { get; set; }
        public int? TestTubeNumber { get; set; }
        public bool? Required { get; set; }
        public bool? Requested { get; set; }
        public double? EmployeeCost { get; set; }
        public double? MaterialCost { get; set; }
        public double? TotalCost { get; set; }
        public double? TestPrice { get; set; }

        public virtual ICollection<OrderCharges> OrderCharges { get; set; }
        public virtual ICollection<TestEmployee> TestEmployee { get; set; }
        public virtual ICollection<TestMaterials> TestMaterials { get; set; }
        public virtual Assay Assay { get; set; }
        public virtual TestType TestType { get; set; }
    }
}
