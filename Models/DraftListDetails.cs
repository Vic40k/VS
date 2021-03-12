using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class DraftListDetails
    {
        public int Id { get; set; }
        public int HeaderId { get; set; }
        public string Articul { get; set; }
        public string DopCod { get; set; }
        public int OstCount { get; set; }
        public int PlanCount { get; set; }

        public virtual DraftListHeader Header { get; set; }
    }
}
