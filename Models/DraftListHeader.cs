using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class DraftListHeader
    {
        public DraftListHeader()
        {
            DraftListDetails = new HashSet<DraftListDetails>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Cell { get; set; }
        public short Smena { get; set; }
        public int FactoryId { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<DraftListDetails> DraftListDetails { get; set; }
    }
}
