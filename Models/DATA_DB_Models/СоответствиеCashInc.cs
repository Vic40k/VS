using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СоответствиеCashInc
    {
        public int Код { get; set; }
        public string KodCash { get; set; }
        public string KodInc { get; set; }
        public string IncomeStatement { get; set; }
        public short? Znak { get; set; }
        public string Слагаемые { get; set; }
    }
}
