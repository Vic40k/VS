using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ConfDbfSql
    {
        public string DbfName { get; set; }
        public string Sqlname { get; set; }
        public bool? CommonTable { get; set; }
        public DateTime? DataChange { get; set; }
        public string IdName { get; set; }
        public string IdIzgotName { get; set; }
        public string MainIndex { get; set; }
    }
}
