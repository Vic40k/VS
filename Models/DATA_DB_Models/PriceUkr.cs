using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class PriceUkr
    {
        public int RecordId { get; set; }
        public int SafeId { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSpec { get; set; }
        public decimal PriceMin { get; set; }
        public decimal Sebestoimost { get; set; }
        public decimal? ЦенаFob { get; set; }
        public decimal Ssr { get; set; }
        public decimal? ЦенаОлл { get; set; }
        public decimal? PriceNds { get; set; }
    }
}
