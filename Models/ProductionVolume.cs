using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class ProductionVolume
    {
        public int IdIzgot { get; set; }
        public string KodIzgot { get; set; }
        public DateTime Period { get; set; }
        public decimal Volume { get; set; }
        public decimal Shipments { get; set; }
    }
}
