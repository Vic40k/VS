using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class OutlabelTemplates
    {
        public OutlabelTemplates()
        {
            OutlabelBindingTemplates = new HashSet<OutlabelBindingTemplates>();
        }

        public int TemplateId { get; set; }
        public string Name { get; set; }
        public string TemplateData { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Edited { get; set; }
        public int? CreatedHid { get; set; }
        public int? EditedHid { get; set; }
        public bool Deleted { get; set; }
        public bool Locked { get; set; }

        public virtual ICollection<OutlabelBindingTemplates> OutlabelBindingTemplates { get; set; }
    }
}
