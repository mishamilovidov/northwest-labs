using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class Clients
    {
        public Clients()
        {
            ClientContact = new HashSet<ClientContact>();
            Orders = new HashSet<Orders>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientStreet { get; set; }
        public string ClientCity { get; set; }
        public string ClientStateProvince { get; set; }
        public string ClientCountry { get; set; }
        public string ClientPostalCode { get; set; }
        public double? ClientBalance { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        public virtual ICollection<ClientContact> ClientContact { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
