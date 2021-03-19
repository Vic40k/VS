using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class MetodOfPayment
    {
        public short? Kod { get; set; }
        public short IdMetodOfPayment { get; set; }
        public string MetodOfPayment1 { get; set; }
        public short? CreditsDays { get; set; }
        public string Percent { get; set; }
    }
}
