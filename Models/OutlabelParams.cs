using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class OutlabelParams
    {
        public OutlabelParams()
        {
            OutlabelImageLists = new HashSet<OutlabelImageLists>();
        }

        public string ParamId { get; set; }
        public string Name { get; set; }
        public int ValueTypeId { get; set; }
        public bool Deleted { get; set; }
        public bool? IsVisible { get; set; }

        public virtual OutlabelValueTypes ValueType { get; set; }
        public virtual ICollection<OutlabelImageLists> OutlabelImageLists { get; set; }
    }
}
