using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ЦеныДляВнутреннегоИспользования
    {
        public int IdТовара { get; set; }
        public decimal? Цена { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal Ssr { get; set; }
        public decimal ЦенаОлл { get; set; }
        public decimal PriceMin { get; set; }
    }
}
