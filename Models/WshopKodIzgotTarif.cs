using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopKodIzgotTarif
    {
        public int Id { get; set; }
        public string KodIzgot { get; set; }
        public decimal Tarif { get; set; }
        public int Priznak { get; set; }
        public DateTime DateCh { get; set; }
        public int IdIzgot { get; set; }
    }
}
