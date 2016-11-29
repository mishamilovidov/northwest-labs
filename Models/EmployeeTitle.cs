using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class EmployeeTitle
    {
        public EmployeeTitle()
        {
            Employee = new HashSet<Employee>();
        }

        public int EmployeeTitleId { get; set; }
        public string EmployeeTitleDescription { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
