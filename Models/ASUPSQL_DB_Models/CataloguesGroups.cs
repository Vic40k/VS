using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CataloguesGroups
    {
        public int Id { get; set; }
        public int CatalogueType { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public int? Unit { get; set; }
        public int? Idparent { get; set; }
        public byte? NodeLevel { get; set; }
    }
}
