using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Compound = new HashSet<Compound>();
            OrdersDiscounts = new HashSet<OrdersDiscounts>();
            Payments = new HashSet<Payments>();
        }

        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int ClientContactId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderComments { get; set; }
        public bool? OrderRush { get; set; }
        public double? CostEstimate { get; set; }
        public double? OrderCost { get; set; }
        public double? OrderBalance { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? EarlyPaymentDate { get; set; }
        public int EarlyPaymentDiscountId { get; set; }

        public virtual ICollection<Compound> Compound { get; set; }
        public virtual ICollection<OrdersDiscounts> OrdersDiscounts { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ClientContact ClientContact { get; set; }
        public virtual Clients Client { get; set; }
    }
}
