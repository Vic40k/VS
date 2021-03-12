using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ZpCalc
    {
        public int Id { get; set; }
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public int EdTab { get; set; }
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
        public decimal Oklad { get; set; }
        public decimal Dstag { get; set; }
        public decimal Dprem1 { get; set; }
        public decimal Dprem2 { get; set; }
        public decimal Dprem3 { get; set; }
        public decimal Koeff1 { get; set; }
        public decimal Koeff2 { get; set; }
        public decimal Koeff3 { get; set; }
        public decimal TimTab { get; set; }
        public decimal TimNorm { get; set; }
        public decimal TimExp { get; set; }
        public decimal Tarif { get; set; }
        public decimal PrcPrem { get; set; }
        public int OtpD { get; set; }
        public decimal OtpS { get; set; }
        public int BolD { get; set; }
        public decimal BolS { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
    }
}
