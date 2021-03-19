using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PstОстатокПоСкладуTmp
    {
        public int IdСклада { get; set; }
        public int IdТовара { get; set; }
        public decimal? Количество { get; set; }
        public decimal? Цена { get; set; }
        public string Валюта { get; set; }
        public string Наименование { get; set; }
        public string ЕдИзм { get; set; }
        public string Артикул { get; set; }
        public decimal? Zapas { get; set; }
        public int? Flag { get; set; }
        public decimal? AllCount { get; set; }
        public string Place { get; set; }
        public int UserId { get; set; }
    }
}
