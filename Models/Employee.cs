using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Employee
    {
        public Employee()
        {
            CompoundReceipt = new HashSet<CompoundReceipt>();
            TestEmployee = new HashSet<TestEmployee>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int EmployeeTitleId { get; set; }
        public double? EmployeeHourlyRate { get; set; }

        public virtual ICollection<CompoundReceipt> CompoundReceipt { get; set; }
        public virtual ICollection<TestEmployee> TestEmployee { get; set; }
        public virtual EmployeeTitle EmployeeTitle { get; set; }
    }
}
