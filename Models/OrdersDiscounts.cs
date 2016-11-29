using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class OrdersDiscounts
    {
        public int OrderId { get; set; }
        public int DiscountId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Orders Order { get; set; }
    }
}
