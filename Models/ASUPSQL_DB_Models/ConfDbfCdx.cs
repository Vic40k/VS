using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConfDbfCdx
    {
        public string DbfName { get; set; }
        public string CdxName { get; set; }
        public bool CdxMain { get; set; }
        public string CdxVal { get; set; }
        public string CdxTyp { get; set; }
        public string CdxSort { get; set; }
    }
}
