using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestEmployee
    {
        public int TestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Test Test { get; set; }
    }
}
