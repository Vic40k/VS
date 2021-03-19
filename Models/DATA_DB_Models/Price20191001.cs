using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class Price20191001
    {
        public int RecordId { get; set; }
        public int SafeId { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSpec { get; set; }
        public decimal PriceMin { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal ЦенаFob { get; set; }
        public decimal Ssr { get; set; }
        public decimal ЦенаОлл { get; set; }
        public decimal PriceUzmk { get; set; }
        public decimal SsrUzmk { get; set; }
        public decimal? ЦенаУзмк { get; set; }
        public decimal? ЦенаУзмкСейф { get; set; }
        public decimal ЦеныFobРуб { get; set; }
        public decimal? PriceAprel { get; set; }
        public decimal SsrUzmkAprel { get; set; }
        public decimal PriceUzmkAprel { get; set; }
        public decimal SsrAprel { get; set; }
        public decimal ЦпСосенки { get; set; }
        public decimal ЦпТула { get; set; }
        public decimal SsrБезНдс { get; set; }
        public decimal SsrUzmkБезНдс { get; set; }
        public decimal ЦпСосенкиБезНдс { get; set; }
        public decimal ЦпТулаБезНдс { get; set; }
        public decimal PriceMinБезНдс { get; set; }
        public decimal? ПрямыеЗатраты { get; set; }
        public decimal? АмортизацияUzmk { get; set; }
        public decimal? SsrЗаводаUzmk { get; set; }
        public decimal? АмортизацияСосенки { get; set; }
        public decimal? SsrЗаводаСосенки { get; set; }
        public decimal? СредняяСкидка { get; set; }
    }
}
