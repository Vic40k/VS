using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WarehouseTotals
    {
        public string KodIzgot { get; set; }
        public int Tab { get; set; }
        public DateTime Date { get; set; }
        public decimal Tabel { get; set; }
        public double CargoVolume { get; set; }
    }
}
