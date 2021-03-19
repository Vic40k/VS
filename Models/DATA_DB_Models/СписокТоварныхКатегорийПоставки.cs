using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class СписокТоварныхКатегорийПоставки
    {
        public int IdГруппы { get; set; }
        public int IdПодгруппы { get; set; }
        public int IdКатегории { get; set; }
        public string Наименование { get; set; }
        public int? КодСортировки { get; set; }
        public string КодТмс { get; set; }
        public bool? ТолькоВЭксплуатацию { get; set; }
    }
}
