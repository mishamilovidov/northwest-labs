using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class ConditionalTests
    {
        public int TestId { get; set; }
        public DateTime? CustomerRequestDate { get; set; }
        public DateTime? CustomerResponseDate { get; set; }
        public bool? CustomerApproval { get; set; }
    }
}
