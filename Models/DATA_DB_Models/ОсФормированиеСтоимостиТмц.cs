using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models.DATA_DB_Model
{
    public partial class ОсФормированиеСтоимостиТмц
    {
        public int IdTmc { get; set; }
        public decimal? PriceVal { get; set; }
        public int? CurPrice { get; set; }
        public decimal? PriceRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? DostVal { get; set; }
        public int? CurDost { get; set; }
        public decimal? DostRate { get; set; }
        public decimal? Dost { get; set; }
        public decimal? StraxVal { get; set; }
        public int? CurStrax { get; set; }
        public decimal? StraxRate { get; set; }
        public decimal? Strax { get; set; }
        public decimal? PoshlinaVal { get; set; }
        public int? CurPoshlina { get; set; }
        public decimal? PoshlinaRate { get; set; }
        public decimal? Poshlina { get; set; }
        public decimal? Ndsval { get; set; }
        public int? CurNds { get; set; }
        public decimal? Ndsrate { get; set; }
        public decimal? Nds { get; set; }
        public decimal? Total { get; set; }
    }
}
