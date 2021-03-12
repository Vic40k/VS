using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VS_CRM.Models
{
    public partial class WshopSpec
    {
        public int Id { get; set; }
        public string LitPar { get; set; }
        public string Parent { get; set; }
        public string LitCar { get; set; }
        public string Carent { get; set; }
        public int? NppOper { get; set; }
        public int Kol { get; set; }
        public string Nam { get; set; }
        public int? KolPart { get; set; }
        public string KodIzgot { get; set; }
        public int? IdIzgot { get; set; }
        public string KodPar { get; set; }
    }
}
