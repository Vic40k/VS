using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechOsnastkaKatCategOsn
    {
        public int Key { get; set; }
        public byte? Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TemplateForToolName { get; set; }
    }
}
