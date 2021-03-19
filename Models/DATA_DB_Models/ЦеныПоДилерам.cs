using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЦеныПоДилерам
    {
        public int RecordId { get; set; }
        public int IdДилера { get; set; }
        public int IdТовара { get; set; }
        public double ЦенаСНдс { get; set; }
        public double ЦенаСНдсМ { get; set; }
        public double ЦенаСНдсР { get; set; }
        public double ЦенаСНдсВ { get; set; }
        public double ЦенаСНдсЮ { get; set; }
    }
}
