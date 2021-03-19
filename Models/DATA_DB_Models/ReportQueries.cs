using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ReportQueries
    {
        public int QueryId { get; set; }
        public int ReportId { get; set; }
        public string QueryName { get; set; }
        public int QueryType { get; set; }
        public string Query { get; set; }
        public short Level { get; set; }
        public int? DetailQueryId { get; set; }
        public string ExcelRange { get; set; }
        public string KeyId { get; set; }
    }
}
