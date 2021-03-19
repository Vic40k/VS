using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокОкраскиЗависимости
    {
        public string IdОкраски { get; set; }
        public string IdКонструкции { get; set; }
        public decimal? Норма { get; set; }
        public int? IdНомера { get; set; }
        public decimal? Цена { get; set; }
    }
}
