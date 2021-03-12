using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class VZakArtic
    {
        public long? RowNumber { get; set; }
        public string Articul { get; set; }
        public decimal? AsVvod { get; set; }
        public decimal? AsVyvod { get; set; }
        public string Bai { get; set; }
        public DateTime? Dat { get; set; }
        public DateTime? Datsavesql { get; set; }
        public string DopCod { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public decimal? Kol { get; set; }
        public decimal? KolIzg { get; set; }
        public decimal? KolSub { get; set; }
        public string Mem { get; set; }
        public string NSub { get; set; }
        public bool? PlLog { get; set; }
        public decimal? Pos { get; set; }
        public decimal? Price { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? PriceOpt { get; set; }
        public string Prim { get; set; }
        public bool? Prizn { get; set; }
        public bool? Priznak { get; set; }
        public bool Delrecord { get; set; }
        public string OrderNo { get; set; }
        public int? TorecId { get; set; }
        public DateTime? DatePlan { get; set; }
        public string NRekl { get; set; }
        public string City { get; set; }
        public DateTime? DateNewPlan { get; set; }
        public string ПерерасходNSub { get; set; }
        public int ZakIdrec { get; set; }
    }
}
