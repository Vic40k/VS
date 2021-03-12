using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ArtKodizgot
    {
        public int IdRec { get; set; }
        public int IdIzgot { get; set; }
        public int KodIzgot { get; set; }
        public string Articul { get; set; }
        public int DopCod { get; set; }
        public string Operation { get; set; }
        public decimal Tarif { get; set; }
        public decimal Norm { get; set; }
        public decimal Zp { get; set; }
        public string PrType { get; set; }
        public bool? IsSummary { get; set; }
        public string ChangeUser { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
