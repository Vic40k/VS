using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ScanerError
    {
        public int RecId { get; set; }
        public DateTime? Date { get; set; }
        public string Action { get; set; }
        public string Err { get; set; }
        public string FactoryId { get; set; }
        public string Params { get; set; }
    }
}
