using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class TechComplect
    {
        public string Bai { get; set; }
        public string Complect { get; set; }
        public DateTime? Datachange { get; set; }
        public DateTime? Datsavesql { get; set; }
        public int? Idizgot { get; set; }
        public int Idrec { get; set; }
        public string KodIzgot { get; set; }
        public string Nam { get; set; }
        public decimal? Tim { get; set; }
        public bool Delrecord { get; set; }
        public decimal? SquareComplect { get; set; }
        public decimal? QuantityMaterial { get; set; }
        public byte? MaterialType { get; set; }
    }
}
