using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class CatCatВ
    {
        public int IdDet { get; set; }
        public string Nam { get; set; }
        public string Articul { get; set; }
        public string EdIzm { get; set; }
        public string Bai { get; set; }
        public DateTime DataIzm { get; set; }
        public bool? Dostup { get; set; }
    }
}
