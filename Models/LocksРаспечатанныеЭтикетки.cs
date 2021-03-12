using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class LocksРаспечатанныеЭтикетки
    {
        public int RecId { get; set; }
        public int LockId { get; set; }
        public string ArticulTo { get; set; }
        public int? Model { get; set; }
        public int? Version { get; set; }
        public DateTime? Date { get; set; }
        public string SerialNumber { get; set; }
        public int FactoryId { get; set; }
        public int? MakerNumber { get; set; }
        public int Number { get; set; }
        public int ReportId { get; set; }
        public string User { get; set; }
        public DateTime? PrintDate { get; set; }
    }
}
