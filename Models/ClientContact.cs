using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class ClientContact
    {
        public ClientContact()
        {
            Orders = new HashSet<Orders>();
        }

        public int ClientContactId { get; set; }
        public string ClientContactFirstName { get; set; }
        public string ClientContactLastName { get; set; }
        public string ClientContactPhone { get; set; }
        public string ClientContactEmail { get; set; }
        public int ClientId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Clients Client { get; set; }
    }
}
