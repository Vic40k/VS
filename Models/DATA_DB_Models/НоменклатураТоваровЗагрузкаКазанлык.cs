using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class НоменклатураТоваровЗагрузкаКазанлык
    {
        public string Articul { get; set; }
        public decimal? QuantityProducedDay { get; set; }
        public string Group { get; set; }
        public int IdТовара { get; set; }
        public string Наименование { get; set; }
        public string Артикул { get; set; }
        public string КодТовара { get; set; }
        public int? IdPlantType42 { get; set; }
        public string PrType { get; set; }
        public int? IdGr { get; set; }
    }
}
