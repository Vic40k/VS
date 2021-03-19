using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class OutlabelBindingTemplates
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int? FactoryId { get; set; }
        public string Articul { get; set; }
        public string Zakaz { get; set; }
        public bool? IsDefault { get; set; }

        public virtual OutlabelTemplates Template { get; set; }
    }
}
