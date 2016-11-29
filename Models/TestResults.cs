using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class TestResults
    {
        public int TestId { get; set; }
        public string TestResult { get; set; }
        public string TestResultVal { get; set; }
        public string TestResultComments { get; set; }
        public int TestSequence { get; set; }
    }
}
