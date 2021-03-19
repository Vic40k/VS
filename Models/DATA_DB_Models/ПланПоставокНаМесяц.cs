using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ПланПоставокНаМесяц
    {
        public short? Год { get; set; }
        public short? Месяц { get; set; }
        public int? IdТовара { get; set; }
        public decimal? Количество { get; set; }
        public int? IdСубсчета { get; set; }
    }
}
