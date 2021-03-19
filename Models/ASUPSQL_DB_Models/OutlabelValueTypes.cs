using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class OutlabelValueTypes
    {
        public OutlabelValueTypes()
        {
            OutlabelParams = new HashSet<OutlabelParams>();
        }

        public int ValueTypeId { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public virtual ICollection<OutlabelParams> OutlabelParams { get; set; }
    }
}
