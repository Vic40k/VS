using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class RepReports
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportPath { get; set; }
        public int ReportType { get; set; }
        public string Filter { get; set; }
        public string FileName { get; set; }
        public int? DocId { get; set; }
    }
}
