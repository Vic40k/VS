using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсReports
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public string ReportPath { get; set; }
        public int ReportType { get; set; }
        public string Filter { get; set; }
        public string FileName { get; set; }
    }
}
