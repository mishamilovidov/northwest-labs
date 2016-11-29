using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Discount
    {
        public Discount()
        {
            OrdersDiscounts = new HashSet<OrdersDiscounts>();
        }

        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public int DiscountTypeId { get; set; }
        public double? DiscountAmount { get; set; }

        public virtual ICollection<OrdersDiscounts> OrdersDiscounts { get; set; }
        public virtual DiscountType DiscountType { get; set; }
    }
}
