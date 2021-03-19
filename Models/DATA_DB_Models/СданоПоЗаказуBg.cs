using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СданоПоЗаказуBg
    {
        public int? НомерЗаказа { get; set; }
        public int IdТовара { get; set; }
        public decimal? Expr1 { get; set; }
        public DateTime? ДатаПерваяКазанлык { get; set; }
        public string Где { get; set; }
        public DateTime? ДатаПоследнейСдачи { get; set; }
        public string OrderNo { get; set; }
        public string NSub { get; set; }
    }
}
