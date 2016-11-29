using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class OrderDetails
    {
        public int OrderId { get; set; }
        public int LineItemId { get; set; }
        public int AssayTypeId { get; set; }

        public virtual AssayType AssayType { get; set; }
    }
}
