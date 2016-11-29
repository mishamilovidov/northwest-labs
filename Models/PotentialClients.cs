using System;
using System.Collections.Generic;

namespace NorthwestLabsPrep.Models
{
    public partial class PotentialClients
    {
        public int ClientId { get; set; }
        public DateTime? DateContacted { get; set; }
        public string Comments { get; set; }
    }
}
