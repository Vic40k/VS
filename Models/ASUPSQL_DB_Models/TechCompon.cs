using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechCompon
    {
        public string Component { get; set; }
        public DateTime? Datsavesql { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string KodIzgot { get; set; }
        public decimal? KolCom { get; set; }
        public decimal? KolK { get; set; }
        public string Lit { get; set; }
        public bool? Log { get; set; }
        public decimal? Oper { get; set; }
        public decimal? Takt { get; set; }
        public decimal? Tim { get; set; }
        public string UpCod { get; set; }
        public bool Delrecord { get; set; }
        public decimal? SquareComponent { get; set; }
        public decimal? QuantityMaterial { get; set; }
        public byte? MaterialType { get; set; }
        public bool HidePosition { get; set; }
        public string Bai { get; set; }
    }
}
