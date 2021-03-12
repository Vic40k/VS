using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class KachKartDefCatalogue
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte ProductionType { get; set; }
        public byte? ColumnNumber { get; set; }
        public bool Exclude { get; set; }
        public bool? GroupItem { get; set; }
        public int? IdGroup { get; set; }
    }
}
