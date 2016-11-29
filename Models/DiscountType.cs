using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class DiscountType
    {
        public DiscountType()
        {
            Discount = new HashSet<Discount>();
        }

        public int DiscountTypeId { get; set; }
        public string DiscountDescription { get; set; }

        public virtual ICollection<Discount> Discount { get; set; }
    }
}
